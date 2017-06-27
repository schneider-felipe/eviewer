namespace eViewer.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.Utils.Animation.FadeTransition fadeTransition1 = new DevExpress.Utils.Animation.FadeTransition();
            this.brmMain = new DevExpress.XtraBars.BarManager(this.components);
            this.barToolBar = new DevExpress.XtraBars.Bar();
            this.btnMenuAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuExportar = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.menuArquivo = new DevExpress.XtraBars.BarSubItem();
            this.menuItemAbrir = new DevExpress.XtraBars.BarButtonItem();
            this.menuItemSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.menuItemExportar = new DevExpress.XtraBars.BarButtonItem();
            this.menuAjuda = new DevExpress.XtraBars.BarSubItem();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.statusArquivo = new DevExpress.XtraBars.BarStaticItem();
            this.barLayout = new DevExpress.XtraBars.Bar();
            this.cboLayout = new DevExpress.XtraBars.BarEditItem();
            this.repCboLayout = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnLayoutSalvar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dcmMain = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dcpPropriedades = new DevExpress.XtraBars.Docking.DockPanel();
            this.dcpPropriedades_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ltcPropriedades = new DevExpress.XtraLayout.LayoutControl();
            this.grdPropriedades = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.lcgPropriedades = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPropriedades = new DevExpress.XtraLayout.LayoutControlItem();
            this.hideContainerBottom = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dcpDetalhes = new DevExpress.XtraBars.Docking.DockPanel();
            this.dcpDetalhes_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.menuExibir = new DevExpress.XtraBars.BarSubItem();
            this.dlfMain = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dmgMain = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabvMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.docgMain = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.docTree = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.docGrid = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.docPivot = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.wrkMain = new DevExpress.Utils.WorkspaceManager();
            this.opfMain = new System.Windows.Forms.OpenFileDialog();
            this.svfMain = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.brmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboLayout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcmMain)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dcpPropriedades.SuspendLayout();
            this.dcpPropriedades_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ltcPropriedades)).BeginInit();
            this.ltcPropriedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPropriedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPropriedades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPropriedades)).BeginInit();
            this.hideContainerBottom.SuspendLayout();
            this.dcpDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dmgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPivot)).BeginInit();
            this.SuspendLayout();
            // 
            // brmMain
            // 
            this.brmMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barToolBar,
            this.barMenu,
            this.barStatus,
            this.barLayout});
            this.brmMain.DockControls.Add(this.barDockControlTop);
            this.brmMain.DockControls.Add(this.barDockControlBottom);
            this.brmMain.DockControls.Add(this.barDockControlLeft);
            this.brmMain.DockControls.Add(this.barDockControlRight);
            this.brmMain.DockManager = this.dcmMain;
            this.brmMain.Form = this;
            this.brmMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuArquivo,
            this.menuAjuda,
            this.btnMenuAbrir,
            this.btnMenuSalvar,
            this.btnMenuExportar,
            this.menuExibir,
            this.menuItemAbrir,
            this.menuItemSalvar,
            this.menuItemExportar,
            this.statusArquivo,
            this.cboLayout,
            this.btnLayoutSalvar});
            this.brmMain.MainMenu = this.barMenu;
            this.brmMain.MaxItemId = 34;
            this.brmMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCboLayout});
            this.brmMain.StatusBar = this.barStatus;
            // 
            // barToolBar
            // 
            this.barToolBar.BarName = "Tools";
            this.barToolBar.DockCol = 0;
            this.barToolBar.DockRow = 1;
            this.barToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenuAbrir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenuSalvar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenuExportar, true)});
            this.barToolBar.Text = "Tools";
            // 
            // btnMenuAbrir
            // 
            this.btnMenuAbrir.Caption = "Abrir";
            this.btnMenuAbrir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMenuAbrir.Glyph")));
            this.btnMenuAbrir.Id = 9;
            this.btnMenuAbrir.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMenuAbrir.LargeGlyph")));
            this.btnMenuAbrir.Name = "btnMenuAbrir";
            this.btnMenuAbrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuAbrir_ItemClick);
            // 
            // btnMenuSalvar
            // 
            this.btnMenuSalvar.Caption = "Salvar";
            this.btnMenuSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMenuSalvar.Glyph")));
            this.btnMenuSalvar.Id = 10;
            this.btnMenuSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMenuSalvar.LargeGlyph")));
            this.btnMenuSalvar.Name = "btnMenuSalvar";
            this.btnMenuSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuSalvar_ItemClick);
            // 
            // btnMenuExportar
            // 
            this.btnMenuExportar.ActAsDropDown = true;
            this.btnMenuExportar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnMenuExportar.Caption = "Exportar para o Excel";
            this.btnMenuExportar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnMenuExportar.Glyph")));
            this.btnMenuExportar.Id = 11;
            this.btnMenuExportar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnMenuExportar.LargeGlyph")));
            this.btnMenuExportar.Name = "btnMenuExportar";
            this.btnMenuExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenuExportar_ItemClick);
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Custom 3";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuArquivo),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuAjuda)});
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Arquivo";
            // 
            // menuArquivo
            // 
            this.menuArquivo.Caption = "Arquivo";
            this.menuArquivo.Id = 2;
            this.menuArquivo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuItemAbrir),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuItemSalvar),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuItemExportar)});
            this.menuArquivo.Name = "menuArquivo";
            // 
            // menuItemAbrir
            // 
            this.menuItemAbrir.Caption = "Abrir";
            this.menuItemAbrir.Id = 23;
            this.menuItemAbrir.Name = "menuItemAbrir";
            this.menuItemAbrir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuItemAbrir_ItemClick);
            // 
            // menuItemSalvar
            // 
            this.menuItemSalvar.Caption = "Salvar";
            this.menuItemSalvar.Id = 24;
            this.menuItemSalvar.Name = "menuItemSalvar";
            // 
            // menuItemExportar
            // 
            this.menuItemExportar.Caption = "Exportar para o Excel";
            this.menuItemExportar.Id = 25;
            this.menuItemExportar.Name = "menuItemExportar";
            // 
            // menuAjuda
            // 
            this.menuAjuda.Caption = "Ajuda";
            this.menuAjuda.Id = 3;
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAjuda_ItemClick);
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Status bar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statusArquivo)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Status bar";
            // 
            // statusArquivo
            // 
            this.statusArquivo.Caption = "Arquivo";
            this.statusArquivo.Id = 26;
            this.statusArquivo.Name = "statusArquivo";
            this.statusArquivo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barLayout
            // 
            this.barLayout.BarName = "Layout";
            this.barLayout.DockCol = 1;
            this.barLayout.DockRow = 1;
            this.barLayout.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barLayout.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.cboLayout),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLayoutSalvar)});
            this.barLayout.Offset = 143;
            this.barLayout.OptionsBar.AllowRename = true;
            this.barLayout.Text = "Layout";
            // 
            // cboLayout
            // 
            this.cboLayout.Edit = this.repCboLayout;
            this.cboLayout.EditValue = "";
            this.cboLayout.EditWidth = 439;
            this.cboLayout.Id = 27;
            this.cboLayout.Name = "cboLayout";
            // 
            // repCboLayout
            // 
            this.repCboLayout.AutoComplete = false;
            this.repCboLayout.AutoHeight = false;
            this.repCboLayout.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCboLayout.Name = "repCboLayout";
            this.repCboLayout.EditValueChanged += new System.EventHandler(this.repCboLayout_EditValueChanged);
            // 
            // btnLayoutSalvar
            // 
            this.btnLayoutSalvar.Caption = "Salvar layout";
            this.btnLayoutSalvar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLayoutSalvar.Glyph")));
            this.btnLayoutSalvar.Id = 29;
            this.btnLayoutSalvar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLayoutSalvar.LargeGlyph")));
            this.btnLayoutSalvar.Name = "btnLayoutSalvar";
            this.btnLayoutSalvar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLayoutSalvar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(795, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 489);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(795, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(795, 50);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // dcmMain
            // 
            this.dcmMain.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft,
            this.hideContainerBottom});
            this.dcmMain.DockingOptions.HideImmediatelyOnAutoHide = true;
            this.dcmMain.DockModeVS2005FadeFramesCount = 0;
            this.dcmMain.DockModeVS2005FadeSpeed = 0;
            this.dcmMain.Form = this;
            this.dcmMain.MenuManager = this.brmMain;
            this.dcmMain.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.hideContainerLeft.Controls.Add(this.dcpPropriedades);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 50);
            this.hideContainerLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(35, 439);
            // 
            // dcpPropriedades
            // 
            this.dcpPropriedades.Controls.Add(this.dcpPropriedades_Container);
            this.dcpPropriedades.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dcpPropriedades.ID = new System.Guid("79999058-62d0-4685-9c12-d10c93655602");
            this.dcpPropriedades.Location = new System.Drawing.Point(-171, 0);
            this.dcpPropriedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dcpPropriedades.Name = "dcpPropriedades";
            this.dcpPropriedades.Options.ShowCloseButton = false;
            this.dcpPropriedades.OriginalSize = new System.Drawing.Size(200, 200);
            this.dcpPropriedades.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dcpPropriedades.SavedIndex = 0;
            this.dcpPropriedades.Size = new System.Drawing.Size(171, 407);
            this.dcpPropriedades.Text = "Propriedades";
            this.dcpPropriedades.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dcpPropriedades_Container
            // 
            this.dcpPropriedades_Container.Controls.Add(this.ltcPropriedades);
            this.dcpPropriedades_Container.Location = new System.Drawing.Point(3, 20);
            this.dcpPropriedades_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dcpPropriedades_Container.Name = "dcpPropriedades_Container";
            this.dcpPropriedades_Container.Size = new System.Drawing.Size(166, 384);
            this.dcpPropriedades_Container.TabIndex = 0;
            // 
            // ltcPropriedades
            // 
            this.ltcPropriedades.Controls.Add(this.grdPropriedades);
            this.ltcPropriedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltcPropriedades.Location = new System.Drawing.Point(0, 0);
            this.ltcPropriedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltcPropriedades.Name = "ltcPropriedades";
            this.ltcPropriedades.Root = this.lcgPropriedades;
            this.ltcPropriedades.Size = new System.Drawing.Size(166, 384);
            this.ltcPropriedades.TabIndex = 0;
            // 
            // grdPropriedades
            // 
            this.grdPropriedades.FindPanelVisible = true;
            this.grdPropriedades.Location = new System.Drawing.Point(12, 12);
            this.grdPropriedades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPropriedades.Name = "grdPropriedades";
            this.grdPropriedades.OptionsFind.FindDelay = 100;
            this.grdPropriedades.OptionsFind.FindMode = DevExpress.XtraVerticalGrid.FindMode.Always;
            this.grdPropriedades.OptionsFind.ShowClearButton = false;
            this.grdPropriedades.OptionsFind.ShowCloseButton = false;
            this.grdPropriedades.OptionsFind.ShowFindButton = false;
            this.grdPropriedades.OptionsLayout.StoreAppearance = true;
            this.grdPropriedades.OptionsLayout.StoreFormatRules = true;
            this.grdPropriedades.Size = new System.Drawing.Size(142, 360);
            this.grdPropriedades.TabIndex = 4;
            // 
            // lcgPropriedades
            // 
            this.lcgPropriedades.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgPropriedades.GroupBordersVisible = false;
            this.lcgPropriedades.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPropriedades});
            this.lcgPropriedades.Location = new System.Drawing.Point(0, 0);
            this.lcgPropriedades.Name = "lcgPropriedades";
            this.lcgPropriedades.Size = new System.Drawing.Size(166, 384);
            this.lcgPropriedades.TextVisible = false;
            // 
            // lciPropriedades
            // 
            this.lciPropriedades.Control = this.grdPropriedades;
            this.lciPropriedades.Location = new System.Drawing.Point(0, 0);
            this.lciPropriedades.Name = "lciPropriedades";
            this.lciPropriedades.Size = new System.Drawing.Size(146, 364);
            this.lciPropriedades.TextSize = new System.Drawing.Size(0, 0);
            this.lciPropriedades.TextVisible = false;
            // 
            // hideContainerBottom
            // 
            this.hideContainerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.hideContainerBottom.Controls.Add(this.dcpDetalhes);
            this.hideContainerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hideContainerBottom.Location = new System.Drawing.Point(35, 454);
            this.hideContainerBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hideContainerBottom.Name = "hideContainerBottom";
            this.hideContainerBottom.Size = new System.Drawing.Size(760, 35);
            // 
            // dcpDetalhes
            // 
            this.dcpDetalhes.Controls.Add(this.dcpDetalhes_Container);
            this.dcpDetalhes.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dcpDetalhes.FloatVertical = true;
            this.dcpDetalhes.ID = new System.Guid("079e3a09-4b88-407e-86d9-405a05c5b17a");
            this.dcpDetalhes.Location = new System.Drawing.Point(0, 0);
            this.dcpDetalhes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dcpDetalhes.Name = "dcpDetalhes";
            this.dcpDetalhes.Options.ShowCloseButton = false;
            this.dcpDetalhes.OriginalSize = new System.Drawing.Size(200, 99);
            this.dcpDetalhes.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dcpDetalhes.SavedIndex = 0;
            this.dcpDetalhes.Size = new System.Drawing.Size(763, 80);
            this.dcpDetalhes.Text = "Detalhes";
            this.dcpDetalhes.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dcpDetalhes_Container
            // 
            this.dcpDetalhes_Container.Location = new System.Drawing.Point(3, 20);
            this.dcpDetalhes_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dcpDetalhes_Container.Name = "dcpDetalhes_Container";
            this.dcpDetalhes_Container.Size = new System.Drawing.Size(758, 58);
            this.dcpDetalhes_Container.TabIndex = 0;
            // 
            // menuExibir
            // 
            this.menuExibir.Caption = "Exibir";
            this.menuExibir.Id = 12;
            this.menuExibir.Name = "menuExibir";
            // 
            // dlfMain
            // 
            this.dlfMain.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // dmgMain
            // 
            this.dmgMain.ContainerControl = this;
            this.dmgMain.MenuManager = this.brmMain;
            this.dmgMain.View = this.tabvMain;
            this.dmgMain.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabvMain});
            this.dmgMain.DocumentActivate += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.dmgMain_DocumentActivate);
            // 
            // tabvMain
            // 
            this.tabvMain.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.docgMain});
            this.tabvMain.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.docTree,
            this.docGrid,
            this.docPivot});
            dockingContainer1.Element = this.docgMain;
            this.tabvMain.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1});
            this.tabvMain.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabvMain_QueryControl);
            // 
            // docgMain
            // 
            this.docgMain.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.docTree,
            this.docGrid,
            this.docPivot});
            // 
            // docTree
            // 
            this.docTree.Caption = "Exibição hierárquica";
            this.docTree.ControlName = "document1";
            this.docTree.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.docTree.Tag = "1";
            // 
            // docGrid
            // 
            this.docGrid.Caption = "Exibição agrupada";
            this.docGrid.ControlName = "document2";
            this.docGrid.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.docGrid.Tag = "2";
            // 
            // docPivot
            // 
            this.docPivot.Caption = "Tabela dinâmica";
            this.docPivot.ControlName = "document3";
            this.docPivot.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.docPivot.Tag = "3";
            // 
            // wrkMain
            // 
            this.wrkMain.TargetControl = this;
            this.wrkMain.TransitionType = fadeTransition1;
            // 
            // opfMain
            // 
            this.opfMain.Filter = "Arquivo Excel|*.xls";
            // 
            // svfMain
            // 
            this.svfMain.DefaultExt = "*.xls";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 513);
            this.Controls.Add(this.hideContainerBottom);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eViewer - Visualizador de eventos do eSocial - [Desenvolvido por Felipe Schneider" +
    "]";
            ((System.ComponentModel.ISupportInitialize)(this.brmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboLayout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcmMain)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dcpPropriedades.ResumeLayout(false);
            this.dcpPropriedades_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ltcPropriedades)).EndInit();
            this.ltcPropriedades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPropriedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPropriedades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPropriedades)).EndInit();
            this.hideContainerBottom.ResumeLayout(false);
            this.dcpDetalhes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dmgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docPivot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager brmMain;
        private DevExpress.XtraBars.Bar barToolBar;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlfMain;
        private DevExpress.XtraBars.BarSubItem menuArquivo;
        private DevExpress.XtraBars.BarSubItem menuAjuda;
        private DevExpress.XtraBars.BarButtonItem btnMenuAbrir;
        private DevExpress.XtraBars.BarButtonItem btnMenuSalvar;
        private DevExpress.XtraBars.Docking.DockManager dcmMain;        
        private DevExpress.XtraBars.Docking2010.DocumentManager dmgMain;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabvMain;
        private DevExpress.XtraBars.Docking.DockPanel dcpPropriedades;
        private DevExpress.XtraBars.Docking.ControlContainer dcpPropriedades_Container;
        private DevExpress.XtraLayout.LayoutControl ltcPropriedades;
        private DevExpress.XtraVerticalGrid.PropertyGridControl grdPropriedades;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPropriedades;
        private DevExpress.XtraLayout.LayoutControlItem lciPropriedades;
        private DevExpress.XtraBars.BarButtonItem btnMenuExportar;
        private DevExpress.XtraBars.BarSubItem menuExibir;
        private DevExpress.Utils.WorkspaceManager wrkMain;
        private DevExpress.XtraBars.Docking.DockPanel dcpDetalhes;
        private DevExpress.XtraBars.Docking.ControlContainer dcpDetalhes_Container;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup docgMain;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document docTree;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document docGrid;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document docPivot;
        private DevExpress.XtraBars.BarButtonItem menuItemAbrir;
        private DevExpress.XtraBars.BarButtonItem menuItemSalvar;
        private DevExpress.XtraBars.BarButtonItem menuItemExportar;
        private System.Windows.Forms.OpenFileDialog opfMain;
        private DevExpress.XtraBars.BarStaticItem statusArquivo;
        private DevExpress.XtraBars.Bar barLayout;
        private DevExpress.XtraBars.BarEditItem cboLayout;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repCboLayout;
        private DevExpress.XtraBars.BarButtonItem btnLayoutSalvar;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerBottom;
        private System.Windows.Forms.SaveFileDialog svfMain;

    }
}

