using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
  public partial class GridView : UserControl
  {
    public GridView()
    {
      InitializeComponent();
    }

    public object DataSource
    {
      get => dataGridView1.DataSource;
      set => dataGridView1.DataSource = value;
    }
  }
}
