using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using eViewer.Classes;
using eViewer.Forms;

namespace eViewer.UserControls
{
    public partial class UserControlViewTree : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlViewTree()
        {
            InitializeComponent();
        }
        public void DataSourceRefresh()
        {
            trvViewTree.DataSource = DataHelper.DataSource;
            trvViewTree.ExpandAll();
        }
    }
}
