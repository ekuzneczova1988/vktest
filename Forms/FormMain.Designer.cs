namespace VKTest
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colstatus;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAccounts = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAccounts = new DevExpress.XtraGrid.GridControl();
            this.baseAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewAccounts = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colavatar = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBandMain = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.collogin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpass = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcookie = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colproxy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coluserAgent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.collink = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnickName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colButtonSetTask = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.buttonSetTask = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coltask = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colenabled = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colcountersLimitDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.xtraTabPageMessaging = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageEvents = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButtonAddAccount = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDell = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonIdea = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPlay = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonStop = new DevExpress.XtraEditors.SimpleButton();
            colstatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSetTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colstatus
            // 
            colstatus.AppearanceCell.Options.UseTextOptions = true;
            colstatus.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Character;
            colstatus.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            colstatus.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            colstatus.Caption = "Статус";
            colstatus.ColumnEdit = this.repositoryItemMemoEdit1;
            colstatus.FieldName = "status";
            colstatus.Name = "colstatus";
            colstatus.OptionsColumn.ReadOnly = true;
            colstatus.RowCount = 2;
            colstatus.RowIndex = 1;
            colstatus.Visible = true;
            colstatus.Width = 523;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.ReadOnly = true;
            this.repositoryItemMemoEdit1.WordWrap = false;
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 90);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageAccounts;
            this.xtraTabControlMain.Size = new System.Drawing.Size(634, 351);
            this.xtraTabControlMain.TabIndex = 0;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageAccounts,
            this.xtraTabPageMessaging,
            this.xtraTabPageEvents});
            // 
            // xtraTabPageAccounts
            // 
            this.xtraTabPageAccounts.Controls.Add(this.gridControlAccounts);
            this.xtraTabPageAccounts.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageAccounts.Image")));
            this.xtraTabPageAccounts.Name = "xtraTabPageAccounts";
            this.xtraTabPageAccounts.Size = new System.Drawing.Size(628, 320);
            this.xtraTabPageAccounts.Text = "Анкеты";
            // 
            // gridControlAccounts
            // 
            this.gridControlAccounts.DataSource = this.baseAccountBindingSource;
            this.gridControlAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "blackList";
            gridLevelNode2.RelationName = "dialogs";
            this.gridControlAccounts.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlAccounts.Location = new System.Drawing.Point(0, 0);
            this.gridControlAccounts.MainView = this.gridViewAccounts;
            this.gridControlAccounts.Name = "gridControlAccounts";
            this.gridControlAccounts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1,
            this.repositoryItemCheckEdit1,
            this.buttonSetTask,
            this.repositoryItemMemoEdit1});
            this.gridControlAccounts.Size = new System.Drawing.Size(628, 320);
            this.gridControlAccounts.TabIndex = 0;
            this.gridControlAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccounts});
            // 
            // baseAccountBindingSource
            // 
            this.baseAccountBindingSource.DataSource = typeof(VKTest.Data.BaseAccount);
            // 
            // gridViewAccounts
            // 
            this.gridViewAccounts.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBandMain});
            this.gridViewAccounts.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colavatar,
            this.collogin,
            this.colpass,
            this.colcookie,
            this.colproxy,
            this.coluserAgent,
            this.collink,
            this.colnickName,
            this.coltask,
            this.colenabled,
            this.colcountersLimitDate,
            colstatus,
            this.colButtonSetTask});
            this.gridViewAccounts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewAccounts.GridControl = this.gridControlAccounts;
            this.gridViewAccounts.Name = "gridViewAccounts";
            this.gridViewAccounts.OptionsView.ColumnAutoWidth = true;
            this.gridViewAccounts.OptionsView.ShowColumnHeaders = false;
            this.gridViewAccounts.OptionsView.ShowDetailButtons = false;
            this.gridViewAccounts.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewAccounts.OptionsView.ShowGroupPanel = false;
            this.gridViewAccounts.OptionsView.ShowIndicator = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Аватар";
            this.gridBand1.Columns.Add(this.colavatar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 75;
            // 
            // colavatar
            // 
            this.colavatar.AutoFillDown = true;
            this.colavatar.Caption = "Аватар";
            this.colavatar.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colavatar.FieldName = "avatar";
            this.colavatar.Name = "colavatar";
            this.colavatar.OptionsColumn.AllowEdit = false;
            this.colavatar.OptionsColumn.AllowMove = false;
            this.colavatar.OptionsColumn.AllowSize = false;
            this.colavatar.OptionsColumn.FixedWidth = true;
            this.colavatar.Visible = true;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.repositoryItemPictureEdit1.ReadOnly = true;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.repositoryItemPictureEdit1.ZoomAccelerationFactor = 1D;
            this.repositoryItemPictureEdit1.ZoomPercent = 150D;
            // 
            // gridBandMain
            // 
            this.gridBandMain.Caption = "Общая информация";
            this.gridBandMain.Columns.Add(this.collogin);
            this.gridBandMain.Columns.Add(this.colpass);
            this.gridBandMain.Columns.Add(this.colcookie);
            this.gridBandMain.Columns.Add(this.colproxy);
            this.gridBandMain.Columns.Add(this.coluserAgent);
            this.gridBandMain.Columns.Add(this.collink);
            this.gridBandMain.Columns.Add(this.colnickName);
            this.gridBandMain.Columns.Add(this.colButtonSetTask);
            this.gridBandMain.Columns.Add(this.coltask);
            this.gridBandMain.Columns.Add(this.colenabled);
            this.gridBandMain.Columns.Add(this.colcountersLimitDate);
            this.gridBandMain.Columns.Add(colstatus);
            this.gridBandMain.Name = "gridBandMain";
            this.gridBandMain.VisibleIndex = 1;
            this.gridBandMain.Width = 523;
            // 
            // collogin
            // 
            this.collogin.FieldName = "login";
            this.collogin.Name = "collogin";
            // 
            // colpass
            // 
            this.colpass.FieldName = "pass";
            this.colpass.Name = "colpass";
            // 
            // colcookie
            // 
            this.colcookie.FieldName = "cookie";
            this.colcookie.Name = "colcookie";
            // 
            // colproxy
            // 
            this.colproxy.FieldName = "proxy";
            this.colproxy.Name = "colproxy";
            // 
            // coluserAgent
            // 
            this.coluserAgent.FieldName = "userAgent";
            this.coluserAgent.Name = "coluserAgent";
            // 
            // collink
            // 
            this.collink.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.collink.AppearanceCell.Options.UseFont = true;
            this.collink.Caption = "Ссылка";
            this.collink.FieldName = "link";
            this.collink.Name = "collink";
            this.collink.OptionsColumn.FixedWidth = true;
            this.collink.OptionsColumn.ReadOnly = true;
            this.collink.Visible = true;
            this.collink.Width = 150;
            // 
            // colnickName
            // 
            this.colnickName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.colnickName.AppearanceCell.Options.UseFont = true;
            this.colnickName.Caption = "Имя";
            this.colnickName.FieldName = "nickName";
            this.colnickName.Name = "colnickName";
            this.colnickName.OptionsColumn.AllowEdit = false;
            this.colnickName.OptionsColumn.ReadOnly = true;
            this.colnickName.Visible = true;
            this.colnickName.Width = 193;
            // 
            // colButtonSetTask
            // 
            this.colButtonSetTask.Caption = "Настроить задания";
            this.colButtonSetTask.ColumnEdit = this.buttonSetTask;
            this.colButtonSetTask.Name = "colButtonSetTask";
            this.colButtonSetTask.OptionsColumn.FixedWidth = true;
            this.colButtonSetTask.Visible = true;
            this.colButtonSetTask.Width = 150;
            // 
            // buttonSetTask
            // 
            serializableAppearanceObject1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            serializableAppearanceObject1.Options.UseFont = true;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            serializableAppearanceObject2.Options.UseFont = true;
            serializableAppearanceObject3.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject3.Options.UseFont = true;
            serializableAppearanceObject4.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            serializableAppearanceObject4.Options.UseFont = true;
            this.buttonSetTask.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Наcтроить задания", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("buttonSetTask.Buttons"))), "", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, true)});
            this.buttonSetTask.Name = "buttonSetTask";
            this.buttonSetTask.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.buttonSetTask.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonSetTask_ButtonClick);
            // 
            // coltask
            // 
            this.coltask.FieldName = "task";
            this.coltask.Name = "coltask";
            // 
            // colenabled
            // 
            this.colenabled.Caption = "Вкл";
            this.colenabled.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colenabled.FieldName = "enabled";
            this.colenabled.Name = "colenabled";
            this.colenabled.OptionsColumn.FixedWidth = true;
            this.colenabled.ToolTip = "Активация заданий";
            this.colenabled.Visible = true;
            this.colenabled.Width = 30;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.PictureChecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureChecked")));
            this.repositoryItemCheckEdit1.PictureUnchecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureUnchecked")));
            // 
            // colcountersLimitDate
            // 
            this.colcountersLimitDate.FieldName = "countersLimitDate";
            this.colcountersLimitDate.Name = "colcountersLimitDate";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.repositoryItemImageEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // xtraTabPageMessaging
            // 
            this.xtraTabPageMessaging.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageMessaging.Image")));
            this.xtraTabPageMessaging.Name = "xtraTabPageMessaging";
            this.xtraTabPageMessaging.Size = new System.Drawing.Size(628, 320);
            this.xtraTabPageMessaging.Text = "Сообщения";
            // 
            // xtraTabPageEvents
            // 
            this.xtraTabPageEvents.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageEvents.Image")));
            this.xtraTabPageEvents.Name = "xtraTabPageEvents";
            this.xtraTabPageEvents.Size = new System.Drawing.Size(628, 320);
            this.xtraTabPageEvents.Text = "События";
            // 
            // simpleButtonAddAccount
            // 
            this.simpleButtonAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonAddAccount.Image")));
            this.simpleButtonAddAccount.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonAddAccount.Location = new System.Drawing.Point(12, 12);
            this.simpleButtonAddAccount.Name = "simpleButtonAddAccount";
            this.simpleButtonAddAccount.Size = new System.Drawing.Size(70, 70);
            this.simpleButtonAddAccount.TabIndex = 1;
            this.simpleButtonAddAccount.Text = "Добавить \r\nанкеты";
            this.simpleButtonAddAccount.ToolTip = "Добавить новые анкеты для работы";
            this.simpleButtonAddAccount.Click += new System.EventHandler(this.simpleButtonAddAccount_Click);
            // 
            // simpleButtonDell
            // 
            this.simpleButtonDell.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDell.Image")));
            this.simpleButtonDell.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonDell.Location = new System.Drawing.Point(87, 12);
            this.simpleButtonDell.Name = "simpleButtonDell";
            this.simpleButtonDell.Size = new System.Drawing.Size(69, 70);
            this.simpleButtonDell.TabIndex = 2;
            this.simpleButtonDell.Text = "Удалить\r\nанкету";
            this.simpleButtonDell.ToolTip = "Удалить выбранную анкету";
            this.simpleButtonDell.Click += new System.EventHandler(this.simpleButtonDell_Click);
            // 
            // simpleButtonIdea
            // 
            this.simpleButtonIdea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonIdea.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonIdea.Image")));
            this.simpleButtonIdea.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonIdea.Location = new System.Drawing.Point(553, 12);
            this.simpleButtonIdea.Name = "simpleButtonIdea";
            this.simpleButtonIdea.Size = new System.Drawing.Size(70, 70);
            this.simpleButtonIdea.TabIndex = 3;
            this.simpleButtonIdea.Text = "Отправить\r\nидею";
            this.simpleButtonIdea.ToolTip = "Добавить новую анкету для работы";
            // 
            // simpleButtonPlay
            // 
            this.simpleButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonPlay.Image")));
            this.simpleButtonPlay.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonPlay.Location = new System.Drawing.Point(246, 12);
            this.simpleButtonPlay.Name = "simpleButtonPlay";
            this.simpleButtonPlay.Size = new System.Drawing.Size(70, 70);
            this.simpleButtonPlay.TabIndex = 4;
            this.simpleButtonPlay.Text = "Запустить\r\nвсе";
            this.simpleButtonPlay.ToolTip = "Добавить новую анкету для работы";
            this.simpleButtonPlay.Click += new System.EventHandler(this.simpleButtonPlay_Click);
            // 
            // simpleButtonStop
            // 
            this.simpleButtonStop.Enabled = false;
            this.simpleButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonStop.Image")));
            this.simpleButtonStop.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButtonStop.Location = new System.Drawing.Point(322, 12);
            this.simpleButtonStop.Name = "simpleButtonStop";
            this.simpleButtonStop.Size = new System.Drawing.Size(70, 70);
            this.simpleButtonStop.TabIndex = 5;
            this.simpleButtonStop.Text = "Остановить\r\nвсе";
            this.simpleButtonStop.ToolTip = "Добавить новую анкету для работы";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.simpleButtonStop);
            this.Controls.Add(this.simpleButtonPlay);
            this.Controls.Add(this.simpleButtonIdea);
            this.Controls.Add(this.simpleButtonDell);
            this.Controls.Add(this.simpleButtonAddAccount);
            this.Controls.Add(this.xtraTabControlMain);
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSetTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageAccounts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageMessaging;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageEvents;
        private DevExpress.XtraGrid.GridControl gridControlAccounts;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddAccount;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDell;
        private DevExpress.XtraEditors.SimpleButton simpleButtonIdea;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPlay;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStop;
        public DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManagerMain;
        private System.Windows.Forms.BindingSource baseAccountBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView gridViewAccounts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colavatar;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn collogin;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpass;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcookie;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colproxy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coluserAgent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn collink;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnickName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltask;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colenabled;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcountersLimitDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colButtonSetTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonSetTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandMain;
    }
}

