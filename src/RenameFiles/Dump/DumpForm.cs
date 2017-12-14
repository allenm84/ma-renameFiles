using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
  public partial class DumpForm : BaseForm
  {
    public DumpForm()
    {
      InitializeComponent();
    }

    public void AddTab(string title, IEnumerable items)
    {
      var list = new ArrayList();
      foreach (var item in items)
      {
        list.Add(item);
      }

      var grid = new GridView();
      grid.DataSource = list;
      grid.Dock = DockStyle.Fill;

      if (string.IsNullOrWhiteSpace(title))
        title = items.GetType().Name;

      var tab = new TabPage(title);
      tab.Controls.Add(grid);
      tabControl1.TabPages.Add(tab);
    }
  }
}
