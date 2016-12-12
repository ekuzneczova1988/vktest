using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace VKTest.Data
{
    [Serializable]
    class VKAccount : BaseAccount
    {
        public VKAccount(string login, string pass, string proxy = null, string ua = null) : base(login, pass, proxy, ua)
        {
        }
        public override bool Auth()
        {
            CookieDictionary ReturnCookies = new CookieDictionary(false);
            string Captcha_sid = "";
            string Captcha_key = "";
            string HtmlAnswer = "";             //name="ip_h" value="
            string LinkAnswer = "";
            using (var getEnter = new HttpRequest())
            {
                getEnter.Cookies = ReturnCookies;
                getEnter.UserAgent = userAgent;
                string Params = getEnter.Get("http://m.vk.com/").ToString().Substring("m.vk.com&", "role");
                string ip_h = Params.Substring("ip_h=", "&");
                string lg_h = Params.Substring("lg_h=", "&");
                for (bool noCapcha = false; noCapcha == false;)
                {
                    getEnter.Cookies = ReturnCookies;
                    getEnter.UserAgent = userAgent;
                    Captcha_sid = LinkAnswer.Substring("sid=", "&");
                    getEnter.AddParam("email", login).AddParam("pass", pass); try
                    {
                        HttpResponse resp = getEnter.Post("http://login.vk.com/?act=login&_origin=http://m.vk.com&ip_h=" + ip_h + "&lg_h=" + lg_h + "&role=pda&utf8=1");
                        LinkAnswer = resp.Address.ToString();
                        HtmlAnswer = resp.ToString();
                    }
                    catch
                    {
                        return false;
                    }
                    Captcha_sid = LinkAnswer.Substring("sid=", "&");
                    if (Captcha_sid != "")
                    {
                        try
                        {
                            byte[] bmpData = new WebClient().DownloadData("http://vk.com/captcha.php?sid=" + Captcha_sid);
                            using (MemoryStream ms = new MemoryStream(bmpData))
                            {
                                Bitmap bmp = (Bitmap)Bitmap.FromStream(ms);
                                // TODO: Работа с капчей
                                //HelpClass HC = new HelpClass();
                                //Captcha_key = HC.Captcha(bmp);
                            }
                        }
                        catch
                        {
                        }
                        getEnter.AddParam("captcha_key", Captcha_key).AddParam("captcha_sid", Captcha_sid);
                    }
                    else
                    {
                        noCapcha = true;
                    }
                }
                if (LinkAnswer.IndexOf("blocked") != -1)
                {
                    return false;
                }
                if (LinkAnswer.IndexOf("email") != -1)
                {
                    return false;
                }
                if (LinkAnswer.IndexOf("security_check") != -1)
                {
                    string[] FragAll = HtmlAnswer.Substrings("<span class=\"field_prefix\">", "</span>");
                    string FragA = "";
                    string FragB = "";
                    Regex pars = new Regex(@"[0-9]");
                    {
                        Match elem = pars.Match(FragAll[0]);
                        while (elem.Success)
                        {
                            FragA += elem.Value;
                            elem = elem.NextMatch();
                        }
                    }
                    {
                        Match elem = pars.Match(FragAll[1]);
                        while (elem.Success)
                        {
                            FragB += elem.Value;
                            elem = elem.NextMatch();
                        }
                    }

                    string Code = login.Substring(FragA, FragB);
                    string Hash = HtmlAnswer.Substring("security_check&to=&hash=", "\"");
                    using (var PostPhone = new HttpRequest())
                    {
                        PostPhone.UserAgent = userAgent;
                        PostPhone.Cookies = ReturnCookies;
                        PostPhone.AddParam("al", "1").AddParam("al_page", "3").AddParam("code", Code).AddParam("hash", Hash).AddParam("to", "");
                        string ResponsePost = PostPhone.Post("https://vk.com/login.php?act=security_check").ToString();
                        if (ResponsePost.IndexOf("К сожалению, цифры указаны неверно.") != -1)
                        {
                            return false;
                        }
                    }
                }
                if (ReturnCookies.ToString().IndexOf("sid") != -1)
                {
                    cookie = ReturnCookies;
                    return true;
                }
            }
            return false;
        }
    }
}
