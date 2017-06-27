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
    public partial class UserControlViewPivot : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlViewPivot()
        {
            InitializeComponent();
        }
        public void DataSourceRefresh()
        {
            grdViewPivot.DataSource = DataHelper.DataSource;
            grdViewPivot.RetrieveFields();
        }
    }
}
