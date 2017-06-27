namespace eViewer.UserControls
{
    partial class UserControlViewPivot
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
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grdViewPivot = new DevExpress.XtraPivotGrid.PivotGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPivot)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(518, 542);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(518, 542);
            this.lcgMain.TextVisible = false;
            // 
            // grdViewPivot
            // 
            this.grdViewPivot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdViewPivot.Location = new System.Drawing.Point(0, 0);
            this.grdViewPivot.Name = "grdViewPivot";
            this.grdViewPivot.Size = new System.Drawing.Size(518, 542);
            this.grdViewPivot.TabIndex = 1;
            // 
            // UserControlViewPivot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdViewPivot);
            this.Controls.Add(this.lcMain);
            this.Name = "UserControlViewPivot";
            this.Size = new System.Drawing.Size(518, 542);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewPivot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        public DevExpress.XtraPivotGrid.PivotGridControl grdViewPivot;
    }
}
