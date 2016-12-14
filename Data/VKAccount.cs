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
                        SetStatus($"Авторизация {login} - не удалось отправить запрос");
                        return false;
                    }
                    Captcha_sid = LinkAnswer.Substring("sid=", "&");
                    if (Captcha_sid != "")
                    {
                        SetStatus($"Авторизация {login} - встретили капчу");
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
                    SetStatus($"Аккаунт {login} - заблокирован");
                    return false;
                }
                if (LinkAnswer.IndexOf("email") != -1)
                {
                    SetStatus($"Авторизация {login} - ошибка почты");
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
                    SetStatus($"Авторизация {login} - прошла успешно");
                    return true;
                }
            }
            SetStatus($"Авторизация {login} - НЕ удалось");
            return false;
        }
        public override bool UpdateAccountInfo()
        {
            long CurrentTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0)).TotalSeconds;
            string s = SendRequest($"https://vk.com/al_im.php?act=a_get_fast_chat&al=1");// &cache_time={CurrentTimestamp}
            var rq = processVkResponse(s);
            foreach (var str in rq)
            {
                try
                {
                    JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(str);
                    nickName = (string)jObject["me"]["name"];
                    link = "vk.com" + (string)jObject["me"]["link"];
                    string linkToAvatar = (string)jObject["me"]["photo"];
                    avatar = LoadPicture(linkToAvatar);
                    SetStatus($"Обновление основных данных {login} - прошло успешно");
                    return true;
                }
                catch (Exception e)
                {
                    SetStatus($"Обновление основных данных {login} - НЕ удалось");
                }
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

        public override List<Dialog> GetDialogs()
        {
            List<Dialog> result = new List<Dialog>();
            string s = SendRequest("https://vk.com/al_im.php?act=a_dialogs_preload&al=1&gid=0");
            var rq = processVkResponse(s);
            foreach (var str in rq)
            {
                try
                {

                    JArray jArray = JArray.Parse(str);
                    foreach (var item in jArray)
                    {
                        Dialog dialog = new Dialog();
                        if (item.Count() >= 6)
                        {
                            dialog.fromId = (string)item[0];
                            dialog.fromNickName = (string)item[1];
                            if (item[2].Count() == 0)
                                dialog.linkToAvatar = (string)item[2];
                            else
                                dialog.linkToAvatar = (string)item[2][0];

                            dialog.secuenceNumber = (int)item[3];
                            dialog.linkToProfile = (string)item[4];
                            if ((int)item[5] == 0)
                                dialog.online = false;
                            else
                                dialog.online = true;
                        }
                        if (item.Count() == 7)
                        {
                            dialog.isFriend = (bool)item[6];
                        }
                        // Пробуем перенести ранее загруженные разговоры
                        var tempMessages = dialogs.Where(w => w.fromId == dialog.fromId).Select(q => q.messages).FirstOrDefault();
                        if (tempMessages != null)
                            dialog.messages = tempMessages;

                        result.Add(dialog);
                    }
                    if (result.Count > 0)
                        dialogs = result;
                    //nickName = (string)jObject["me"]["name"];
                    //link = "vk.com" + (string)jObject["me"]["link"];
                    //string linkToAvatar = (string)jObject["me"]["photo"];
                    //avatar = LoadPicture(linkToAvatar);

                    SetStatus($"Обновление диалогов {login} - прошло успешно");
                    return result;
                }
                catch (Exception e)
                {
                    SetStatus($"Обновление диалогов {login} - НЕ удалось");
                }
            }
            return result;
        }
        public override List<Message> GetDialog(string id)
        {
            List<Message> result = new List<Message>();
            string s = SendRequest($"https://vk.com/al_im.php?act=a_start&al=1&block=true&gid=0&history=true&msgid=false&peer={id}&prevpeer=0");
            var rq = processVkResponse(s);
            var dialog = dialogs.Where(w => w.fromId == id).FirstOrDefault();
            foreach (var str in rq)
            {
                try
                {
                    if (str == "[]")
                        continue;
                    JObject jObject = JObject.Parse(str);
                    dialog.online = (bool)jObject["online"];
                    foreach (var item in jObject["msgs"].Children())
                    {
                        Console.WriteLine("Item ID: {0}", item.First()[5]);
                        Message message = new Message();
                        var sss = item.Values()[3].ToString();
                        message.id = (int)item.First()[0];
                        /// 6
                        if ((int)item.First()[1] == 19 || (int)item.First()[1] == 18)
                            message.incoming = false;
                        else
                            message.incoming = true;
                        message.idContact = (int)item.First()[2];
                        message.date = UnixTimeStampToDateTime((double)item.First()[3]);
                        message.msg = (string)item.First()[5];
                        result.Add(message);
                    }
                    SetStatus($"Обновление диалога с {dialog.fromNickName} - прошло успешно");
                    //return result;
                }
                catch (Exception e)
                {
                    SetStatus($"Обновление диалога с {dialog.fromNickName} - НЕ удалось");
                }
            }
            dialog.messages = result;
            return result;
        }
        public override void CheckMessage()
        {
            string[] authLongPol = GetKeyForLongPol();
            while (enabled)
            {
                string url = $"{authLongPol[0]}/{authLongPol[1]}?act=a_check&key={authLongPol[2]}&mode=202&ts={authLongPol[3]}&version=1&wait=25";
                using (var get = new HttpRequest())
                {
                    Console.WriteLine("Проверяем: {0}", authLongPol[3]);
                    get.ConnectTimeout = 30000;
                    get.Cookies = GetCookies();
                    get.UserAgent = userAgent;
                    var resp = get.Post(url).ToString();
                    if (get.Response.StatusCode == xNet.HttpStatusCode.Forbidden)
                    {
                        authLongPol = GetKeyForLongPol();
                        continue;
                    }
                    JObject jObject = JObject.Parse(resp);
                    // Обновляем ts
                    authLongPol[3] = jObject["ts"].ToString();
                    foreach (var item in jObject["updates"].Children())
                    {
                        Console.WriteLine("Получено сообщение от: {0}", item[0].ToString());
                        if (item[0].ToString() == "4")
                            Console.WriteLine("Получено сообщение от: {0}, '{1}'", item[3], item[6]);
                    }
                }
            }
        }
        private string[] GetKeyForLongPol()
        {
            string[] result = new string[4];
            string s = SendRequest($"https://vk.com/im").Substring("IM.init({\"id\"", "})");
            var json = JObject.Parse("{\"id\"" + s + "}");
            /// unread_dialogs
            /// unread_cnt
            /// +url
            /// +key
            /// thash
            /// +ts
            /// +lhost
            /// unread_dialogs
            result[0] = json["lhost"].ToString();
            result[1] = json["url"].ToString();
            result[2] = json["key"].ToString();
            result[3] = json["ts"].ToString();
            return result;
        }
        public override string SendRequest(string req)
        {
            string result = "";
            using (var get = new HttpRequest())
            {
                get.Cookies = GetCookies();
                get.UserAgent = userAgent;
                var resp = get.Post(req).ToString();
                if (resp.IndexOf("<!>3<!>") > -1 || resp.IndexOf("<div id=\"login_message\"><div class=\"msg info_msg\"><div class=\"msg_text\">") > -1)
                {
                    Auth();
                    get.Cookies = GetCookies();
                    resp = get.Post(req).ToString();
                }
                result = resp.ToString();//.Substring("<!json>", "-->"); 1})
            }
            return result;
        }
    }
}
