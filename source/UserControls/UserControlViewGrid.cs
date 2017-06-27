using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using eViewer.Classes;
using eViewer.Forms;

namespace eViewer.UserControls
{
    public partial class UserControlViewGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlViewGrid()
        {
            InitializeComponent();            
        }

        public void DataSourceRefresh()
        {
            grdViewGrid.DataSource = DataHelper.DataSource;
        }
    }
}
