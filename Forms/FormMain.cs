using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;
using eViewer.Classes;
using eViewer.UserControls;

namespace eViewer.Forms
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private UserControlViewGrid _viewGrid;
        private UserControlViewPivot _viewPivot;
        private UserControlViewTree _viewTree;

        public FormMain()
        {
            InitializeComponent();

            this.Width = 1000;
            this.Height = 800;

            statusArquivo.Caption = string.Empty;

            _viewGrid = new UserControlViewGrid();
            _viewPivot = new UserControlViewPivot();
            _viewTree = new UserControlViewTree();

            foreach (var item in Directory.GetDirectories(PathsHelper.LayoutPath))
            {
                repCboLayout.Items.Add(Path.GetFileName(item));                
            }
        }

        private void tabvMain_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            grdPropriedades.SuspendLayout();
            switch (e.Document.Tag.ToString())
            {
                case "1":
                    e.Control = _viewTree;
                    grdPropriedades.SelectedObject = _viewTree.trvViewTree;
                    break;
                case "2":
                    e.Control = _viewGrid;
                    grdPropriedades.SelectedObject = _viewGrid.grvViewGrid;
                    break;
                case "3":
                    e.Control = _viewPivot;
                    grdPropriedades.SelectedObject = _viewPivot.grdViewPivot;
                    break;
            }
            grdPropriedades.ExpandAllRows();
            grdPropriedades.CollapseAllRows();
            grdPropriedades.ResumeLayout();
        }

        private void btnMenuAbrir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (opfMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DataHelper.Filename = opfMain.FileName;
                    statusArquivo.Caption = opfMain.FileName;
                    _viewTree.DataSourceRefresh();
                    _viewGrid.DataSourceRefresh();
                    _viewPivot.DataSourceRefresh();
                }
            }
            catch
            {
                MessageBox.Show("Erro ao abrir arquivo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void dmgMain_DocumentActivate(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            try
            {
                if (e.Document.Tag != null)
                {
                    grdPropriedades.SuspendLayout();
                    switch (e.Document.Tag.ToString())
                    {
                        case "1":
                            grdPropriedades.SelectedObject = _viewTree.trvViewTree;
                            break;
                        case "2":
                            grdPropriedades.SelectedObject = _viewGrid.grvViewGrid;
                            break;
                        case "3":
                            grdPropriedades.SelectedObject = _viewPivot.grdViewPivot;
                            break;
                    }
                    grdPropriedades.ExpandAllRows();
                    grdPropriedades.CollapseAllRows();
                    grdPropriedades.ResumeLayout();
                }
            }
            catch { }
        }

        private void menuItemAbrir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenuAbrir_ItemClick(sender, null);
        }

        private void btnLayoutSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {               
                string currentLayout = (string)cboLayout.EditValue;
                if (currentLayout == string.Empty)
                {
                    MessageBox.Show("Informe o nome do layout.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Deseja salvar o layout?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        wrkMain.CaptureWorkspace(currentLayout);

                        if (!Directory.Exists(PathsHelper.LayoutPath + currentLayout))
                        {
                            Directory.CreateDirectory(PathsHelper.LayoutPath + currentLayout);
                        }
                        wrkMain.SaveWorkspace(currentLayout, PathsHelper.LayoutPath + currentLayout + @"\form.config");
                        TreeListViewStateHelper layoutTree = new TreeListViewStateHelper(_viewTree.trvViewTree);
                        layoutTree.SaveState(PathsHelper.LayoutPath + currentLayout + @"\tree.config");
                        if (!repCboLayout.Items.Contains(currentLayout))
                        {
                            repCboLayout.Items.Add(currentLayout);
                        }
                        MessageBox.Show("Layout salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao salvar o layout.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repCboLayout_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLayout = (sender as ComboBoxEdit).Text;
                if (File.Exists(PathsHelper.LayoutPath + currentLayout + @"\form.config"))
                {
                    if (currentLayout == string.Empty)
                    {
                        MessageBox.Show("Informe o nome do layout.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        wrkMain.LoadWorkspace(currentLayout, PathsHelper.LayoutPath + currentLayout + @"\form.config");
                        wrkMain.ApplyWorkspace(currentLayout);
                        TreeListViewStateHelper layoutTree = new TreeListViewStateHelper(_viewTree.trvViewTree);
                        layoutTree.LoadState(PathsHelper.LayoutPath + currentLayout + @"\tree.config");
                    }
                }
                cboLayout.EditValue = currentLayout;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar o layout.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuExportar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (svfMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _viewTree.trvViewTree.ExportToXls(svfMain.FileName);
                MessageBox.Show("Arquivo salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMenuSalvar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void menuAjuda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Desenvolvido por Felipe Schneider" + Environment.NewLine + "schneider.felipe@gmail.com", "Ajuda");
        }
    }
}
