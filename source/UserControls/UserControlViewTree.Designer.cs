namespace eViewer.UserControls
{
    partial class UserControlViewTree
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
            this.trvViewTree = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.trvViewTree)).BeginInit();
            this.SuspendLayout();
            // 
            // trvViewTree
            // 
            this.trvViewTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvViewTree.Location = new System.Drawing.Point(0, 0);
            this.trvViewTree.Name = "trvViewTree";
            this.trvViewTree.OptionsLayout.StoreAppearance = true;
            this.trvViewTree.OptionsView.AutoWidth = false;
            this.trvViewTree.Size = new System.Drawing.Size(784, 639);
            this.trvViewTree.TabIndex = 0;
            // 
            // UserControlViewTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvViewTree);
            this.Name = "UserControlViewTree";
            this.Size = new System.Drawing.Size(784, 639);
            ((System.ComponentModel.ISupportInitialize)(this.trvViewTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraTreeList.TreeList trvViewTree;

    }
}
