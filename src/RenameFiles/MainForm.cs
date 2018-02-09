using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs;

namespace RenameFiles
{
  public partial class MainForm : BaseForm
  {
    private readonly string mSettingsPath;
    private readonly SemaphoreSlim mSavephore;

    public MainForm()
    {
      mSettingsPath = Path.Combine(Application.StartupPath, "settings.xml");
      mSavephore = new SemaphoreSlim(1, 1);

      InitializeComponent();
      LoadSettings();

      directoryInfoBindingSource.ListChanged += BindingSource_ListChanged;
      renameRuleBindingSource.ListChanged += BindingSource_ListChanged;
    }

    private static async void Yield<T>(Action<T> method, T arg)
    {
      await Task.Yield();
      try { method.Invoke(arg); }
      catch { }
    }

    private void LoadSettings()
    {
      if (!File.Exists(mSettingsPath))
      {
        return;
      }

      try
      {
        using (var stream = File.OpenRead(mSettingsPath))
        {
          var dcs = new DataContractSerializer(typeof(RenameFilesSettings));
          if (dcs.ReadObject(stream) is RenameFilesSettings settings)
          {
            settings.Directories?.ForEach(d => directoryInfoBindingSource.Add(d));
            settings.Rules?.ForEach(r => renameRuleBindingSource.Add(r));
          }
        }
      }
      catch (Exception ex)
      {
        Yield(ShowError, $"Couldn't load settings: {ex.Message}");
      }
    }

    private async void SaveSettings()
    {
      // cache the data we need to save
      var directories = directoryInfoBindingSource
        .OfType<DirectoryInfo>()
        .ToArray();
      var rules = renameRuleBindingSource
        .OfType<RenameRule>()
        .ToArray();

      // create the settings and write them to the file
      var settings = new RenameFilesSettings
      {
        Directories = new List<DirectoryInfo>(directories),
        Rules = new List<RenameRule>(rules),
      };

      await mSavephore.WaitAsync();
      try
      {
        var data = await Task.Run(() =>
        {
          var memStream = new MemoryStream();
          var dcs = new DataContractSerializer(typeof(RenameFilesSettings));
          dcs.WriteObject(memStream, settings);
          return memStream;
        });

        File.WriteAllBytes(mSettingsPath, data.ToArray());
      }
      catch (Exception ex)
      {
        ShowError($"Couldn't save settings: {ex.Message}");
      }
      mSavephore.Release();
    }

    private void ShowError(string message)
    {
      MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private HashSet<string> GetCurrentDirectories()
    {
      var directories = directoryInfoBindingSource
        .OfType<DirectoryInfo>()
        .Select(d => Path.GetFullPath(d.FullName));
      return new HashSet<string>(directories, StringComparer.OrdinalIgnoreCase);
    }

    private DataGridViewRow GetRow(DirectoryInfo directory)
    {
      return gridDirectories.Rows
        .OfType<DataGridViewRow>()
        .FirstOrDefault(r => ReferenceEquals(r.DataBoundItem, directory));
    }

    private DataGridViewRow GetRow(RenameRule rule)
    {
      return gridRules.Rows
        .OfType<DataGridViewRow>()
        .FirstOrDefault(r => ReferenceEquals(r.DataBoundItem, rule));
    }

    private void AddDirectory()
    {
      using (var dlg = new VistaFolderBrowserDialog())
      {
        dlg.ShowNewFolderButton = false;
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
          var existing = GetCurrentDirectories();
          var path = Path.GetFullPath(dlg.SelectedPath);
          if (existing.Add(path))
          {
            directoryInfoBindingSource.Add(new DirectoryInfo(path));
          }
        }
      }
    }

    private void AddRule()
    {
      var rule = new RenameRule
      {
        Enabled = true,
        Contains = "<Contains>",
        Format = "<Format>",
        Pattern = "<Pattern>",
      };
      renameRuleBindingSource.Add(rule);

      var row = GetRow(rule);
      if (row != null)
      {
        gridRules.ClearSelection();
        gridRules.FirstDisplayedScrollingRowIndex = row.Index;
        row.Selected = true;
      }
    }

    private bool Confirm(string message, string caption)
    {
      return MessageBox.Show(this, message, caption, 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      timerSaveSettings.Stop();
      timerSaveSettings.Start();
    }

    private void gridRules_SelectionChanged(object sender, EventArgs e)
    {
      editorSelectedRule.SelectedObjects = gridRules.SelectedRows
        .OfType<DataGridViewRow>()
        .Select(r => r.DataBoundItem)
        .ToArray();
    }

    private void btnNewDirectory_Click(object sender, EventArgs e)
    {
      AddDirectory();
    }

    private void btnNewRule_Click(object sender, EventArgs e)
    {
      AddRule();
    }

    private void btnRun_Click(object sender, EventArgs e)
    {
      var directories = directoryInfoBindingSource
        .OfType<DirectoryInfo>()
        .ToArray();
      var rules = renameRuleBindingSource
        .OfType<RenameRule>()
        .ToArray();

      Renamer.Run(this, directories, rules);
      SaveSettings();
    }

    private void timerSaveSettings_Tick(object sender, EventArgs e)
    {
      SaveSettings();
    }

    private void deleteDirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var selectedRows = gridDirectories.SelectedRows;
      if (selectedRows.Count > 0 && Confirm("Are you sure you want to remove the selected directories?", "Confirm"))
      {
        var dirs = selectedRows
          .OfType<DataGridViewRow>()
          .Select(r => r.DataBoundItem as DirectoryInfo)
          .ToArray();
        foreach (var dir in dirs)
        {
          directoryInfoBindingSource.Remove(dir);
        }
      }
    }
  }
}
