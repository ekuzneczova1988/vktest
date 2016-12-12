namespace VKTest
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonOk = new DevExpress.XtraEditors.SimpleButton();
            this.memoEditAddAccounts = new DevExpress.XtraEditors.MemoEdit();
            this.labelControlInfoAccountAdd = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonImportFromFile = new DevExpress.XtraEditors.SimpleButton();
            this.imageComboBoxEditSoc = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.imageCollectionSoc = new DevExpress.Utils.ImageCollection(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAddAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEditSoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionSoc)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(507, 293);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(40, 40);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Отмена";
            this.simpleButtonCancel.ToolTip = "Отменить добавление";
            this.simpleButtonCancel.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonOk
            // 
            this.simpleButtonOk.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonOk.Image")));
            this.simpleButtonOk.Location = new System.Drawing.Point(427, 293);
            this.simpleButtonOk.Name = "simpleButtonOk";
            this.simpleButtonOk.Size = new System.Drawing.Size(74, 40);
            this.simpleButtonOk.TabIndex = 1;
            this.simpleButtonOk.Text = "Ок";
            this.simpleButtonOk.ToolTip = "Добавить новые анкеты";
            this.simpleButtonOk.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.simpleButtonOk.Click += new System.EventHandler(this.simpleButtonOk_Click);
            // 
            // memoEditAddAccounts
            // 
            this.memoEditAddAccounts.EditValue = "";
            this.memoEditAddAccounts.Location = new System.Drawing.Point(12, 109);
            this.memoEditAddAccounts.Name = "memoEditAddAccounts";
            this.memoEditAddAccounts.Properties.NullValuePrompt = "Один аккаунт на строке, формат записи: логин, пароль, прокси, user-agent. Раздели" +
    "тель запятая, прокси и user-agent можно не указывать. Разделитель запятая.";
            this.memoEditAddAccounts.Properties.NullValuePromptShowForEmptyValue = true;
            this.memoEditAddAccounts.Properties.ShowNullValuePromptWhenFocused = true;
            this.memoEditAddAccounts.Size = new System.Drawing.Size(535, 178);
            this.memoEditAddAccounts.TabIndex = 2;
            // 
            // labelControlInfoAccountAdd
            // 
            this.labelControlInfoAccountAdd.Location = new System.Drawing.Point(13, 13);
            this.labelControlInfoAccountAdd.Name = "labelControlInfoAccountAdd";
            this.labelControlInfoAccountAdd.Size = new System.Drawing.Size(117, 13);
            this.labelControlInfoAccountAdd.TabIndex = 3;
            this.labelControlInfoAccountAdd.Text = "Добавить анкеты для:";
            // 
            // simpleButtonImportFromFile
            // 
            this.simpleButtonImportFromFile.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonImportFromFile.Image")));
            this.simpleButtonImportFromFile.Location = new System.Drawing.Point(12, 293);
            this.simpleButtonImportFromFile.Name = "simpleButtonImportFromFile";
            this.simpleButtonImportFromFile.Size = new System.Drawing.Size(101, 40);
            this.simpleButtonImportFromFile.TabIndex = 5;
            this.simpleButtonImportFromFile.Text = "Из файла";
            this.simpleButtonImportFromFile.ToolTip = "Загрузить из текстового файла";
            this.simpleButtonImportFromFile.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.simpleButtonImportFromFile.Click += new System.EventHandler(this.simpleButtonImportFromFile_Click);
            // 
            // imageComboBoxEditSoc
            // 
            this.imageComboBoxEditSoc.EditValue = "VK.COM";
            this.imageComboBoxEditSoc.Location = new System.Drawing.Point(12, 32);
            this.imageComboBoxEditSoc.Name = "imageComboBoxEditSoc";
            this.imageComboBoxEditSoc.Properties.AutoComplete = false;
            this.imageComboBoxEditSoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEditSoc.Properties.DropDownRows = 4;
            this.imageComboBoxEditSoc.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("OK.RU", "OK.RU", 4),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("VK.COM", "VK.COM", 5)});
            this.imageComboBoxEditSoc.Properties.SmallImages = this.imageCollectionSoc;
            this.imageComboBoxEditSoc.Size = new System.Drawing.Size(136, 20);
            this.imageComboBoxEditSoc.TabIndex = 6;
            // 
            // imageCollectionSoc
            // 
            this.imageCollectionSoc.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollectionSoc.ImageStream")));
            this.imageCollectionSoc.Images.SetKeyName(0, "facebook.com.png");
            this.imageCollectionSoc.Images.SetKeyName(1, "twitter.com.png");
            this.imageCollectionSoc.Images.SetKeyName(2, "mamba.ru.png");
            this.imageCollectionSoc.Images.SetKeyName(3, "instagram.com.png");
            this.imageCollectionSoc.Images.SetKeyName(4, "ok.ru.png");
            this.imageCollectionSoc.Images.SetKeyName(5, "vk.com.png");
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(293, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(254, 91);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = resources.GetString("labelControl1.Text");
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 345);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.imageComboBoxEditSoc);
            this.Controls.Add(this.simpleButtonImportFromFile);
            this.Controls.Add(this.labelControlInfoAccountAdd);
            this.Controls.Add(this.memoEditAddAccounts);
            this.Controls.Add(this.simpleButtonOk);
            this.Controls.Add(this.simpleButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.memoEditAddAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEditSoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollectionSoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOk;
        private DevExpress.XtraEditors.MemoEdit memoEditAddAccounts;
        private DevExpress.XtraEditors.LabelControl labelControlInfoAccountAdd;
        private DevExpress.XtraEditors.SimpleButton simpleButtonImportFromFile;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEditSoc;
        private DevExpress.Utils.ImageCollection imageCollectionSoc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}