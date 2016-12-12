using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKTest.Data;
using VKTest.Forms;

namespace VKTest
{
    public partial class AddAccount : Form
    {
        public List<BaseAccount> accounts = new List<BaseAccount>();
        public AddAccount()
        {
            InitializeComponent();
        }

        private void simpleButtonOk_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitFormMain), true, true, false);
            foreach (var s in memoEditAddAccounts.Lines)
            {
                BaseAccount type = null;
                char separate = ',';
                string[] props = s.Split(separate);
                string login = null;
                string pass = null;
                string proxy = null;
                string ua = null;
                if (props.Length >= 1)
                    login = props[0].Trim();
                if (props.Length >= 2)
                    pass = props[1].Trim();
                if (props.Length >= 3)
                    proxy = props[2].Trim();
                if (props.Length >= 4)
                    ua = props[3].Trim();
                SplashScreenManager.Default.SetWaitFormDescription($"Загружаем {login} ...");
                if (imageComboBoxEditSoc.SelectedItem.ToString() == "VK.COM")
                {
                    type = new VKAccount(login, pass, proxy, ua);
                    if (type.Auth())
                    {
                        SplashScreenManager.Default.SetWaitFormDescription($"Обновляем основные данные {login} ...");
                        type.UpdateAccountInfo();
                    }
                }
                if (type == null)
                    continue;

                accounts.Add(type);
            }
            SplashScreenManager.CloseForm(false);
            DialogResult = DialogResult.OK;
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void simpleButtonImportFromFile_Click(object sender, EventArgs e)
        {
            if (memoEditAddAccounts.Text != "" || memoEditAddAccounts.Text != null)
            {
                if (MessageBox.Show("Загрузка из файла удалит данные введенные вручную, продолжить?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return;
            }
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                memoEditAddAccounts.ResetText();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        memoEditAddAccounts.MaskBox.AppendText($"{line}{Environment.NewLine}");
                    }
                }
            }
        }
    }
}
