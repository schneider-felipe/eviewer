namespace eViewer.UserControls
{
    partial class UserControlViewGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.grdViewGrid = new DevExpress.XtraGrid.GridControl();
            this.grvViewGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMain = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.grdViewGrid);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(518, 542);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // grdViewGrid
            // 
            this.grdViewGrid.Location = new System.Drawing.Point(12, 12);
            this.grdViewGrid.MainView = this.grvViewGrid;
            this.grdViewGrid.Name = "grdViewGrid";
            this.grdViewGrid.Size = new System.Drawing.Size(494, 518);
            this.grdViewGrid.TabIndex = 4;
            this.grdViewGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvViewGrid});
            // 
            // grvViewGrid
            // 
            this.grvViewGrid.GridControl = this.grdViewGrid;
            this.grvViewGrid.Name = "grvViewGrid";
            this.grvViewGrid.OptionsLayout.StoreAllOptions = true;
            this.grvViewGrid.OptionsLayout.StoreAppearance = true;
            this.grvViewGrid.OptionsLayout.StoreFormatRules = true;
            this.grvViewGrid.OptionsView.ColumnAutoWidth = false;
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMain});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(518, 542);
            this.lcgMain.TextVisible = false;
            // 
            // lciMain
            // 
            this.lciMain.Control = this.grdViewGrid;
            this.lciMain.Location = new System.Drawing.Point(0, 0);
            this.lciMain.Name = "lciMain";
            this.lciMain.Size = new System.Drawing.Size(498, 522);
            this.lciMain.TextSize = new System.Drawing.Size(0, 0);
            this.lciMain.TextVisible = false;
            // 
            // UserControlViewGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcMain);
            this.Name = "UserControlViewGrid";
            this.Size = new System.Drawing.Size(518, 542);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciMain;
        public DevExpress.XtraGrid.Views.Grid.GridView grvViewGrid;
        private DevExpress.XtraGrid.GridControl grdViewGrid;
    }
}
