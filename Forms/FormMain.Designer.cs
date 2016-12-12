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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageAccounts = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlAccounts = new DevExpress.XtraGrid.GridControl();
            this.baseAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabPageMessaging = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPageEvents = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButtonAddAccount = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDell = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonIdea = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPlay = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonStop = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewAccounts = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colavatar = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.collogin = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpass = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcookie = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colproxy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coluserAgent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.collink = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnickName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltask = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colenabled = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcountersLimitDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colstatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBandMain = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.xtraTabPageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 90);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.xtraTabPageAccounts;
            this.xtraTabControlMain.Size = new System.Drawing.Size(627, 357);
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
            this.xtraTabPageAccounts.Size = new System.Drawing.Size(621, 326);
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
            this.gridControlAccounts.Size = new System.Drawing.Size(621, 326);
            this.gridControlAccounts.TabIndex = 0;
            this.gridControlAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAccounts});
            // 
            // baseAccountBindingSource
            // 
            this.baseAccountBindingSource.DataSource = typeof(VKTest.Data.BaseAccount);
            // 
            // xtraTabPageMessaging
            // 
            this.xtraTabPageMessaging.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageMessaging.Image")));
            this.xtraTabPageMessaging.Name = "xtraTabPageMessaging";
            this.xtraTabPageMessaging.Size = new System.Drawing.Size(621, 204);
            this.xtraTabPageMessaging.Text = "Сообщения";
            // 
            // xtraTabPageEvents
            // 
            this.xtraTabPageEvents.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPageEvents.Image")));
            this.xtraTabPageEvents.Name = "xtraTabPageEvents";
            this.xtraTabPageEvents.Size = new System.Drawing.Size(621, 204);
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
            this.simpleButtonIdea.Location = new System.Drawing.Point(546, 12);
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
            this.colstatus});
            this.gridViewAccounts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewAccounts.GridControl = this.gridControlAccounts;
            this.gridViewAccounts.Name = "gridViewAccounts";
            this.gridViewAccounts.OptionsView.ShowColumnHeaders = false;
            this.gridViewAccounts.RowHeight = 2;
            // 
            // colavatar
            // 
            this.colavatar.Caption = "Аватар";
            this.colavatar.FieldName = "avatar";
            this.colavatar.Name = "colavatar";
            this.colavatar.OptionsColumn.AllowEdit = false;
            this.colavatar.OptionsColumn.AllowMove = false;
            this.colavatar.OptionsColumn.AllowSize = false;
            this.colavatar.OptionsColumn.FixedWidth = true;
            this.colavatar.Visible = true;
            this.colavatar.Width = 70;
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
            this.collink.Caption = "Ссылка";
            this.collink.FieldName = "link";
            this.collink.Name = "collink";
            this.collink.Visible = true;
            this.collink.Width = 183;
            // 
            // colnickName
            // 
            this.colnickName.Caption = "Имя";
            this.colnickName.FieldName = "nickName";
            this.colnickName.Name = "colnickName";
            this.colnickName.Visible = true;
            this.colnickName.Width = 320;
            // 
            // coltask
            // 
            this.coltask.FieldName = "task";
            this.coltask.Name = "coltask";
            // 
            // colenabled
            // 
            this.colenabled.Caption = "Вкл";
            this.colenabled.FieldName = "enabled";
            this.colenabled.Name = "colenabled";
            this.colenabled.OptionsColumn.FixedWidth = true;
            this.colenabled.Visible = true;
            this.colenabled.Width = 30;
            // 
            // colcountersLimitDate
            // 
            this.colcountersLimitDate.FieldName = "countersLimitDate";
            this.colcountersLimitDate.Name = "colcountersLimitDate";
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Статус";
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.RowIndex = 1;
            this.colstatus.Visible = true;
            this.colstatus.Width = 603;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Аватар";
            this.gridBand1.Columns.Add(this.colavatar);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.VisibleIndex = 0;
            // 
            // gridBandMain
            // 
            this.gridBandMain.Caption = "Аккаунты";
            this.gridBandMain.Columns.Add(this.collogin);
            this.gridBandMain.Columns.Add(this.colpass);
            this.gridBandMain.Columns.Add(this.colcookie);
            this.gridBandMain.Columns.Add(this.colproxy);
            this.gridBandMain.Columns.Add(this.coluserAgent);
            this.gridBandMain.Columns.Add(this.collink);
            this.gridBandMain.Columns.Add(this.colnickName);
            this.gridBandMain.Columns.Add(this.coltask);
            this.gridBandMain.Columns.Add(this.colenabled);
            this.gridBandMain.Columns.Add(this.colcountersLimitDate);
            this.gridBandMain.Columns.Add(this.colstatus);
            this.gridBandMain.Name = "gridBandMain";
            this.gridBandMain.VisibleIndex = 1;
            this.gridBandMain.Width = 603;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 447);
            this.Controls.Add(this.simpleButtonStop);
            this.Controls.Add(this.simpleButtonPlay);
            this.Controls.Add(this.simpleButtonIdea);
            this.Controls.Add(this.simpleButtonDell);
            this.Controls.Add(this.simpleButtonAddAccount);
            this.Controls.Add(this.xtraTabControlMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.xtraTabPageAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAccounts)).EndInit();
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
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colstatus;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBandMain;
    }
}

