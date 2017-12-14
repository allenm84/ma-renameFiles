namespace RenameFiles
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.gridDirectories = new System.Windows.Forms.DataGridView();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.parentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.existsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.rootDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.creationTimeUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastAccessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastAccessTimeUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastWriteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastWriteTimeUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.directoryInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.gridRules = new System.Windows.Forms.DataGridView();
      this.editorSelectedRule = new System.Windows.Forms.PropertyGrid();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnNewDirectory = new System.Windows.Forms.Button();
      this.btnNewRule = new System.Windows.Forms.Button();
      this.btnRun = new System.Windows.Forms.Button();
      this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.containsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.patternDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.renameRuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.timerSaveSettings = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridDirectories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.directoryInfoBindingSource)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridRules)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.renameRuleBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panel2);
      this.splitContainer1.Size = new System.Drawing.Size(620, 417);
      this.splitContainer1.SplitterDistance = 194;
      this.splitContainer1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.gridDirectories);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(194, 417);
      this.panel1.TabIndex = 2;
      // 
      // gridDirectories
      // 
      this.gridDirectories.AllowUserToAddRows = false;
      this.gridDirectories.AllowUserToDeleteRows = false;
      this.gridDirectories.AllowUserToResizeColumns = false;
      this.gridDirectories.AllowUserToResizeRows = false;
      this.gridDirectories.AutoGenerateColumns = false;
      this.gridDirectories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridDirectories.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridDirectories.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gridDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridDirectories.ColumnHeadersVisible = false;
      this.gridDirectories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.parentDataGridViewTextBoxColumn,
            this.existsDataGridViewCheckBoxColumn,
            this.rootDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.creationTimeUtcDataGridViewTextBoxColumn,
            this.lastAccessTimeDataGridViewTextBoxColumn,
            this.lastAccessTimeUtcDataGridViewTextBoxColumn,
            this.lastWriteTimeDataGridViewTextBoxColumn,
            this.lastWriteTimeUtcDataGridViewTextBoxColumn,
            this.attributesDataGridViewTextBoxColumn});
      this.gridDirectories.DataSource = this.directoryInfoBindingSource;
      this.gridDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridDirectories.Location = new System.Drawing.Point(0, 20);
      this.gridDirectories.Name = "gridDirectories";
      this.gridDirectories.ReadOnly = true;
      this.gridDirectories.RowHeadersVisible = false;
      this.gridDirectories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridDirectories.Size = new System.Drawing.Size(192, 395);
      this.gridDirectories.TabIndex = 1;
      // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      this.nameDataGridViewTextBoxColumn.ReadOnly = true;
      this.nameDataGridViewTextBoxColumn.Visible = false;
      // 
      // fullNameDataGridViewTextBoxColumn
      // 
      this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
      this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
      this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
      this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // parentDataGridViewTextBoxColumn
      // 
      this.parentDataGridViewTextBoxColumn.DataPropertyName = "Parent";
      this.parentDataGridViewTextBoxColumn.HeaderText = "Parent";
      this.parentDataGridViewTextBoxColumn.Name = "parentDataGridViewTextBoxColumn";
      this.parentDataGridViewTextBoxColumn.ReadOnly = true;
      this.parentDataGridViewTextBoxColumn.Visible = false;
      // 
      // existsDataGridViewCheckBoxColumn
      // 
      this.existsDataGridViewCheckBoxColumn.DataPropertyName = "Exists";
      this.existsDataGridViewCheckBoxColumn.HeaderText = "Exists";
      this.existsDataGridViewCheckBoxColumn.Name = "existsDataGridViewCheckBoxColumn";
      this.existsDataGridViewCheckBoxColumn.ReadOnly = true;
      this.existsDataGridViewCheckBoxColumn.Visible = false;
      // 
      // rootDataGridViewTextBoxColumn
      // 
      this.rootDataGridViewTextBoxColumn.DataPropertyName = "Root";
      this.rootDataGridViewTextBoxColumn.HeaderText = "Root";
      this.rootDataGridViewTextBoxColumn.Name = "rootDataGridViewTextBoxColumn";
      this.rootDataGridViewTextBoxColumn.ReadOnly = true;
      this.rootDataGridViewTextBoxColumn.Visible = false;
      // 
      // extensionDataGridViewTextBoxColumn
      // 
      this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
      this.extensionDataGridViewTextBoxColumn.HeaderText = "Extension";
      this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
      this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
      this.extensionDataGridViewTextBoxColumn.Visible = false;
      // 
      // creationTimeDataGridViewTextBoxColumn
      // 
      this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
      this.creationTimeDataGridViewTextBoxColumn.HeaderText = "CreationTime";
      this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
      this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.creationTimeDataGridViewTextBoxColumn.Visible = false;
      // 
      // creationTimeUtcDataGridViewTextBoxColumn
      // 
      this.creationTimeUtcDataGridViewTextBoxColumn.DataPropertyName = "CreationTimeUtc";
      this.creationTimeUtcDataGridViewTextBoxColumn.HeaderText = "CreationTimeUtc";
      this.creationTimeUtcDataGridViewTextBoxColumn.Name = "creationTimeUtcDataGridViewTextBoxColumn";
      this.creationTimeUtcDataGridViewTextBoxColumn.ReadOnly = true;
      this.creationTimeUtcDataGridViewTextBoxColumn.Visible = false;
      // 
      // lastAccessTimeDataGridViewTextBoxColumn
      // 
      this.lastAccessTimeDataGridViewTextBoxColumn.DataPropertyName = "LastAccessTime";
      this.lastAccessTimeDataGridViewTextBoxColumn.HeaderText = "LastAccessTime";
      this.lastAccessTimeDataGridViewTextBoxColumn.Name = "lastAccessTimeDataGridViewTextBoxColumn";
      this.lastAccessTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastAccessTimeDataGridViewTextBoxColumn.Visible = false;
      // 
      // lastAccessTimeUtcDataGridViewTextBoxColumn
      // 
      this.lastAccessTimeUtcDataGridViewTextBoxColumn.DataPropertyName = "LastAccessTimeUtc";
      this.lastAccessTimeUtcDataGridViewTextBoxColumn.HeaderText = "LastAccessTimeUtc";
      this.lastAccessTimeUtcDataGridViewTextBoxColumn.Name = "lastAccessTimeUtcDataGridViewTextBoxColumn";
      this.lastAccessTimeUtcDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastAccessTimeUtcDataGridViewTextBoxColumn.Visible = false;
      // 
      // lastWriteTimeDataGridViewTextBoxColumn
      // 
      this.lastWriteTimeDataGridViewTextBoxColumn.DataPropertyName = "LastWriteTime";
      this.lastWriteTimeDataGridViewTextBoxColumn.HeaderText = "LastWriteTime";
      this.lastWriteTimeDataGridViewTextBoxColumn.Name = "lastWriteTimeDataGridViewTextBoxColumn";
      this.lastWriteTimeDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastWriteTimeDataGridViewTextBoxColumn.Visible = false;
      // 
      // lastWriteTimeUtcDataGridViewTextBoxColumn
      // 
      this.lastWriteTimeUtcDataGridViewTextBoxColumn.DataPropertyName = "LastWriteTimeUtc";
      this.lastWriteTimeUtcDataGridViewTextBoxColumn.HeaderText = "LastWriteTimeUtc";
      this.lastWriteTimeUtcDataGridViewTextBoxColumn.Name = "lastWriteTimeUtcDataGridViewTextBoxColumn";
      this.lastWriteTimeUtcDataGridViewTextBoxColumn.ReadOnly = true;
      this.lastWriteTimeUtcDataGridViewTextBoxColumn.Visible = false;
      // 
      // attributesDataGridViewTextBoxColumn
      // 
      this.attributesDataGridViewTextBoxColumn.DataPropertyName = "Attributes";
      this.attributesDataGridViewTextBoxColumn.HeaderText = "Attributes";
      this.attributesDataGridViewTextBoxColumn.Name = "attributesDataGridViewTextBoxColumn";
      this.attributesDataGridViewTextBoxColumn.ReadOnly = true;
      this.attributesDataGridViewTextBoxColumn.Visible = false;
      // 
      // directoryInfoBindingSource
      // 
      this.directoryInfoBindingSource.DataSource = typeof(System.IO.DirectoryInfo);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(192, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Directories:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.splitContainer2);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(422, 417);
      this.panel2.TabIndex = 2;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer2.Location = new System.Drawing.Point(0, 20);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer2.Panel1
      // 
      this.splitContainer2.Panel1.Controls.Add(this.gridRules);
      // 
      // splitContainer2.Panel2
      // 
      this.splitContainer2.Panel2.Controls.Add(this.editorSelectedRule);
      this.splitContainer2.Size = new System.Drawing.Size(420, 395);
      this.splitContainer2.SplitterDistance = 262;
      this.splitContainer2.TabIndex = 1;
      // 
      // gridRules
      // 
      this.gridRules.AllowUserToAddRows = false;
      this.gridRules.AllowUserToDeleteRows = false;
      this.gridRules.AllowUserToResizeColumns = false;
      this.gridRules.AllowUserToResizeRows = false;
      this.gridRules.AutoGenerateColumns = false;
      this.gridRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridRules.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.gridRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridRules.ColumnHeadersVisible = false;
      this.gridRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enabledDataGridViewCheckBoxColumn,
            this.containsDataGridViewTextBoxColumn,
            this.patternDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn});
      this.gridRules.DataSource = this.renameRuleBindingSource;
      this.gridRules.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridRules.Location = new System.Drawing.Point(0, 0);
      this.gridRules.Name = "gridRules";
      this.gridRules.ReadOnly = true;
      this.gridRules.RowHeadersVisible = false;
      this.gridRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridRules.Size = new System.Drawing.Size(420, 262);
      this.gridRules.TabIndex = 2;
      this.gridRules.SelectionChanged += new System.EventHandler(this.gridRules_SelectionChanged);
      // 
      // editorSelectedRule
      // 
      this.editorSelectedRule.Dock = System.Windows.Forms.DockStyle.Fill;
      this.editorSelectedRule.HelpVisible = false;
      this.editorSelectedRule.LineColor = System.Drawing.SystemColors.ControlDark;
      this.editorSelectedRule.Location = new System.Drawing.Point(0, 0);
      this.editorSelectedRule.Name = "editorSelectedRule";
      this.editorSelectedRule.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
      this.editorSelectedRule.Size = new System.Drawing.Size(420, 129);
      this.editorSelectedRule.TabIndex = 0;
      this.editorSelectedRule.ToolbarVisible = false;
      this.editorSelectedRule.ViewBorderColor = System.Drawing.SystemColors.Window;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.Control;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(420, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Rules:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 447);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel2.Controls.Add(this.btnNewDirectory, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnNewRule, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnRun, 3, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 417);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 30);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // btnNewDirectory
      // 
      this.btnNewDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnNewDirectory.Location = new System.Drawing.Point(3, 3);
      this.btnNewDirectory.Name = "btnNewDirectory";
      this.btnNewDirectory.Size = new System.Drawing.Size(94, 24);
      this.btnNewDirectory.TabIndex = 0;
      this.btnNewDirectory.Text = "New Directory";
      this.btnNewDirectory.UseVisualStyleBackColor = true;
      this.btnNewDirectory.Click += new System.EventHandler(this.btnNewDirectory_Click);
      // 
      // btnNewRule
      // 
      this.btnNewRule.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnNewRule.Location = new System.Drawing.Point(103, 3);
      this.btnNewRule.Name = "btnNewRule";
      this.btnNewRule.Size = new System.Drawing.Size(94, 24);
      this.btnNewRule.TabIndex = 1;
      this.btnNewRule.Text = "New Rule";
      this.btnNewRule.UseVisualStyleBackColor = true;
      this.btnNewRule.Click += new System.EventHandler(this.btnNewRule_Click);
      // 
      // btnRun
      // 
      this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRun.Location = new System.Drawing.Point(523, 3);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(94, 24);
      this.btnRun.TabIndex = 2;
      this.btnRun.Text = "Run";
      this.btnRun.UseVisualStyleBackColor = true;
      this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
      // 
      // enabledDataGridViewCheckBoxColumn
      // 
      this.enabledDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
      this.enabledDataGridViewCheckBoxColumn.FillWeight = 40.60914F;
      this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
      this.enabledDataGridViewCheckBoxColumn.MinimumWidth = 20;
      this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
      this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
      this.enabledDataGridViewCheckBoxColumn.Width = 20;
      // 
      // containsDataGridViewTextBoxColumn
      // 
      this.containsDataGridViewTextBoxColumn.DataPropertyName = "Contains";
      this.containsDataGridViewTextBoxColumn.FillWeight = 119.797F;
      this.containsDataGridViewTextBoxColumn.HeaderText = "Contains";
      this.containsDataGridViewTextBoxColumn.Name = "containsDataGridViewTextBoxColumn";
      this.containsDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // patternDataGridViewTextBoxColumn
      // 
      this.patternDataGridViewTextBoxColumn.DataPropertyName = "Pattern";
      this.patternDataGridViewTextBoxColumn.FillWeight = 119.797F;
      this.patternDataGridViewTextBoxColumn.HeaderText = "Pattern";
      this.patternDataGridViewTextBoxColumn.Name = "patternDataGridViewTextBoxColumn";
      this.patternDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // formatDataGridViewTextBoxColumn
      // 
      this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
      this.formatDataGridViewTextBoxColumn.FillWeight = 119.797F;
      this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
      this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
      this.formatDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // renameRuleBindingSource
      // 
      this.renameRuleBindingSource.DataSource = typeof(RenameFiles.RenameRule);
      // 
      // timerSaveSettings
      // 
      this.timerSaveSettings.Interval = 60;
      this.timerSaveSettings.Tick += new System.EventHandler(this.timerSaveSettings_Tick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 467);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Rename Files";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridDirectories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.directoryInfoBindingSource)).EndInit();
      this.panel2.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridRules)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.renameRuleBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView gridDirectories;
    private System.Windows.Forms.SplitContainer splitContainer2;
    private System.Windows.Forms.DataGridView gridRules;
    private System.Windows.Forms.PropertyGrid editorSelectedRule;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnNewDirectory;
    private System.Windows.Forms.Button btnNewRule;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.BindingSource renameRuleBindingSource;
    private System.Windows.Forms.BindingSource directoryInfoBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn parentDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn existsDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn rootDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeUtcDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessTimeUtcDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastWriteTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastWriteTimeUtcDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn containsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn patternDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
    private System.Windows.Forms.Timer timerSaveSettings;
  }
}

