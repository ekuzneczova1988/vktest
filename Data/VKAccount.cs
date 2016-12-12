using Newtonsoft.Json.Linq;
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
                    getEnter.AddParam("email", login).AddParam("pass", pass);
                    try
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
                    SetCookie(ReturnCookies);
                    return true;
                }
            }
            return false;
        }
        public override bool UpdateAccountInfo()
        {
            long CurrentTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
            string s = SendRequest($"https://vk.com/al_im.php?act=a_get_fast_chat&al=1");// &cache_time={CurrentTimestamp}
            var rq = processVkResponse(s);
            foreach(var str in rq)
            {
                try
                {
                    JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(str);
                    nickName = (string)jObject["me"]["name"];
                    link = "vk.com"+(string)jObject["me"]["link"];
                    string linkToAvatar= (string)jObject["me"]["photo"];
                    avatar = LoadPicture(linkToAvatar);
                    return true;
                }
                catch (Exception e) 
                { }
            }
            return false;
        }
        /// <summary>
        /// Loads an image from a URL into a Bitmap object.
        /// Currently as written if there is an error during downloading of the image, no exception is thrown.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Bitmap LoadPicture(string url)
        {
            System.Net.HttpWebRequest wreq;
            System.Net.HttpWebResponse wresp;
            Stream mystream;
            Bitmap bmp;

            bmp = null;
            mystream = null;
            wresp = null;
            try
            {
                wreq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                wreq.AllowWriteStreamBuffering = true;

                wresp = (System.Net.HttpWebResponse)wreq.GetResponse();

                if ((mystream = wresp.GetResponseStream()) != null)
                    bmp = new Bitmap(mystream);
            }
            catch
            {
                // Do nothing... 
            }
            finally
            {
                if (mystream != null)
                    mystream.Close();

                if (wresp != null)
                    wresp.Close();
            }

            return (bmp);
        }
        List<string> processVkResponse(string _input)
        {
            string pattern = "<!--";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(_input, replacement);
            pattern = "-->";
            rgx = new Regex(pattern);
            result = rgx.Replace(result, replacement);
            // var str = s.replace("< !--", "").replace(/ -<> -(!?) >/ g, '--$1>');

            if (result.Trim().Length == 0)
            {
                // console.error('Response length error');
                return null;
            }
            var answer = result.Split(new string[] { "<!>" }, StringSplitOptions.None);
            return parseRes(answer);
        }
        List<string> parseRes(string[] _input)
        {
            List<string> result = new List<string>();
            foreach (var s in _input)
            {
                if (s.Length < 2)
                    continue;
                if (s.Substring(0, 2) == "<!")
                {
                    var from = s.IndexOf(">");
                    var type = s.Substring(2, from - 2);
                    var temp = s.Substring(from + 1);
                    switch (type)
                    {
                        case "json":
                            result.Add(temp);
                            //answer[i] = _parseJSON(ans);
                            break;
                        case "int":
                            //answer[i] = _intval(ans);
                            break;
                        case "float":
                            //answer[i] = _floatval(ans);
                            break;
                        case "bool":
                            //answer[i] = _intval(ans) ? true : false;
                            break;
                        case "null":
                            //answer[i] = null;
                            break;
                    }
                }
                //else
                //    result.Add(s);
            }
            return result;
        }
    }
}
