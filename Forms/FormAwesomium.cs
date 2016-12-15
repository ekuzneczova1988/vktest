using Awesomium.Core;
using Awesomium.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKTest.Data;

namespace VKTest.Forms
{
    public partial class FormAwesomium : Form
    {
        public class ResourceInterceptor : IResourceInterceptor
        {
            string userAgent = "";
            string extractedHeaders = "";
            public bool OnFilterNavigation(NavigationRequest request)
            {
                //throw new NotImplementedException();
                return true;
            }

            // Note that this is called on the I/O thread.
            ResourceResponse IResourceInterceptor.OnRequest(Awesomium.Core.ResourceRequest request)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(extractedHeaders);

                sb.Append("User-Agent: ")
                    .AppendLine(userAgent);

                sb.AppendLine();

                request.ExtraHeaders = sb.ToString();

                return null;
            }
            public ResourceInterceptor(string ua)
            {
                userAgent = ua;
            }
        }
        BaseAccount account;
        WebControl webcontrol;
        public FormAwesomium(BaseAccount accountIn)
        {
            account = accountIn;
            if (WebCore.UpdateState == WebCoreUpdateState.NotUpdating)
                WebCore.Initialize(new WebConfig() { UserAgent = account.userAgent });
            //else
            //WebCore.ResourceInterceptor = new ResourceInterceptor(account.userAgent);
            InitializeComponent();
            simpleButtonAuth.Text = "Авторизоваться как " + account.nickName;
            WebPreferences webPrefs = new WebPreferences();
            if (account.proxy != "" && account.proxy != null)
                webPrefs.ProxyConfig = account.proxy; // taken out
            WebSession session = WebCore.CreateWebSession(webPrefs);
            webcontrol = new WebControl();
            webcontrol.WebSession = session;
            this.panelControlWeb.Controls.Add(webcontrol);
            webcontrol.Dock = DockStyle.Fill;
            webcontrol.Source = new Uri("https://vk.com/");
            webcontrol.Visible = true;
            //if (account.proxy != "" && account.proxy != null)
            //    webPrefs.ProxyConfig = account.proxy; // taken out
            //WebSession webSession = WebCore.CreateWebSession(AppDomain.CurrentDomain.BaseDirectory + "websession", webPrefs);
            //webControlMain.WebSession = webSession;
            //  webControlMain.WebSession.ClearCookies();
            //webControlMain.Source = new Uri("https://vk.com/");
        }

        private void Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(object sender, Awesomium.Core.ShowCreatedWebViewEventArgs e)
        {
        }

        private void simpleButtonAuth_Click(object sender, EventArgs e)
        {
            //webControlMain.WebSession.ClearCookies();
            dynamic document = (JSObject)webcontrol.ExecuteJavascriptWithResult("document");
            if (document == null)
            {
                return;
            }
            using (document)
            {
                string cc = document.cookie;
                webcontrol.WebSession.ClearCookies();
                for (int i = 0; i < account.cookie.Count; i++)
                {
                    document.cookie = account.cookie[i];
                }
                // document.cookie = "remixsid=7213cf5ad339e50391b5ce28eca7f317c4f99454629d96cff8a0c";
            }
            webcontrol.Source = new Uri("https://vk.com/");
        }

        private void FormAwesomium_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public bool OnFilterNavigation(NavigationRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
