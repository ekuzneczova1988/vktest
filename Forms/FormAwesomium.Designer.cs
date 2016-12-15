namespace VKTest.Forms
{
    partial class FormAwesomium
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonAuth = new DevExpress.XtraEditors.SimpleButton();
            this.panelControlWeb = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.simpleButtonAuth);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1076, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButtonAuth
            // 
            this.simpleButtonAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAuth.Location = new System.Drawing.Point(12, 5);
            this.simpleButtonAuth.Name = "simpleButtonAuth";
            this.simpleButtonAuth.Size = new System.Drawing.Size(1059, 36);
            this.simpleButtonAuth.TabIndex = 0;
            this.simpleButtonAuth.Text = "Авторизация";
            this.simpleButtonAuth.Click += new System.EventHandler(this.simpleButtonAuth_Click);
            // 
            // panelControlWeb
            // 
            this.panelControlWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlWeb.Location = new System.Drawing.Point(0, 47);
            this.panelControlWeb.Name = "panelControlWeb";
            this.panelControlWeb.Size = new System.Drawing.Size(1076, 502);
            this.panelControlWeb.TabIndex = 1;
            // 
            // FormAwesomium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 548);
            this.Controls.Add(this.panelControlWeb);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormAwesomium";
            this.Text = "Браузер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAwesomium_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControlWeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAuth;
        private DevExpress.XtraEditors.PanelControl panelControlWeb;
    }
}