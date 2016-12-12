﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKTest.Data;
using VKTest.Forms;
using xNet;

namespace VKTest
{
    public partial class FormMain : Form
    {
        List<BaseAccount> accounts = new List<BaseAccount>();
        public FormMain()
        {
            InitializeComponent();
        }
        private CookieDictionary VkCookies(string Login, string Pass, string proxy)
        {
            return null;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //using (var request = new HttpRequest())
            //{
            //    cookie = new CookieDictionary(false);
            //    request.UserAgent = Http.ChromeUserAgent();
            //    request.Cookies = cookie;
            //    string html = request.Get("http://vk.com/?_fm=index").ToString();
            //    string lg_h = html.Substring("lg_h\" value=\"", "\"");
            //    html = request.Get("http://login.vk.com/?act=login&email=" + login + "&pass=" + pass + "&lg_h=" + lg_h + "&role=al_frame").ToString();
            //}
            // var cookie = VkCookies("e.kuzneczova1988@mail.ru", "Qweasdzxc321!", "");

            //FormLogin fl = new FormLogin();
            //fl.ShowDialog();
            if (Directory.Exists($"{AppDomain.CurrentDomain.BaseDirectory}ACCOUNTS\\"))
            foreach(var file in Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}ACCOUNTS\\"))
            {
                accounts.Add((BaseAccount)BaseAccount.Open(file));
            }
            gridControlAccounts.DataSource = accounts;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void simpleButtonAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount aa = new AddAccount();
            if (aa.ShowDialog() == DialogResult.OK)
            {
                accounts.AddRange(aa.accounts);
                gridControlAccounts.DataSource = accounts;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            splashScreenManagerMain.ShowWaitForm();
            foreach (var account in accounts)
            {
                account.Save(account);
            }
            splashScreenManagerMain.CloseWaitForm();
        }

        private void simpleButtonDell_Click(object sender, EventArgs e)
        {
        }

        private void simpleButtonPlay_Click(object sender, EventArgs e)
        {
            var t = (BaseAccount)gridViewAccounts.GetRow(gridViewAccounts.FocusedRowHandle);
            if (t == null)
                return;
            t.UpdateAccountInfo();
        }
    }
}
