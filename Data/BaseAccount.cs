using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using xNet;
using System.Drawing;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace VKTest.Data
{
    [Serializable]
    public class BaseAccount : IAccount
    {
        #region Parametrs
        public System.Drawing.Image avatar
        {
            get
            {
                return _avatar;
            }

            set
            {
                _avatar = value;
            }
        }
        System.Drawing.Image _avatar = null;
        public List<string> blackList
        {
            get
            {
                return _blackList;
            }

            set
            {
                _blackList = value;
            }
        }
        List<string> _blackList = new List<string>();
        public Dictionary<string, string> cookie
        {
            get
            {
                return _cookie;
            }

            set
            {
                _cookie = value;
            }
        }
        Dictionary<string, string> _cookie = new Dictionary<string, string>();
        public DateTime countersLimitDate
        {
            get
            {
                return _countersLimitDate;
            }

            set
            {
                _countersLimitDate = value;
            }
        }
        DateTime _countersLimitDate;
        public List<Dialog> dialogs
        {
            get
            {
                return _dialogs;
            }

            set
            {
                _dialogs = value;
            }
        }
        List<Dialog> _dialogs = new List<Dialog>();
        public bool enabled
        {
            get
            {
                return _enabled;
            }

            set
            {
                _enabled = value;
            }
        }
        bool _enabled = false;
        public string link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }
        string _link;
        public string login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }
        string _login;
        public string nickName
        {
            get
            {
                return _nickName;
            }

            set
            {
                _nickName = value;
            }
        }
        string _nickName = "Не загружено";
        public string status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
        string _status;
        public string pass
        {
            get
            {
                return _pass;
            }

            set
            {
                _pass = value;
            }
        }
        string _pass;
        public string proxy
        {
            get
            {
                return _proxy;
            }

            set
            {
                _proxy = value;
            }
        }
        string _proxy;
        public Task task
        {
            get
            {
                return _task;
            }

            set
            {
                _task = value;
            }
        }
        Task _task;
        public string userAgent
        {
            get
            {
                return _userAgent;
            }

            set
            {
                _userAgent = value;
            }
        }
        string _userAgent;
        #endregion
        public bool AddToFriends(string id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Инициализация анкеты
        /// </summary>
        /// <param name="login">логин (обязательно)</param>
        /// <param name="pass">пароль (обязательно)</param>
        /// <param name="proxy">прокси (не обязательно)</param>
        /// <param name="ua">юзерагент (не обязательно)</param>
        public BaseAccount(string login, string pass, string proxy = null, string ua = null)
        {
            _login = login;
            _pass = pass;
            _proxy = proxy;
            _userAgent = ua;
            if (_userAgent == null)
                _userAgent = Http.ChromeUserAgent();
        }
        public virtual bool Auth()
        {
            throw new NotImplementedException();
        }

        public int CheckMessage()
        {
            throw new NotImplementedException();
        }

        public Dialog GetDialog(string id)
        {
            throw new NotImplementedException();
        }

        public List<Dialog> GetDialogs()
        {
            throw new NotImplementedException();
        }

        public List<string> GetUserIds(string id = null)
        {
            throw new NotImplementedException();
        }

        public bool LikeAvatar(string id)
        {
            throw new NotImplementedException();
        }

        public bool LikePost(string idPost)
        {
            throw new NotImplementedException();
        }

        public byte LikePosts(string id, byte count = 3)
        {
            throw new NotImplementedException();
        }

        public bool SendComment(string id)
        {
            throw new NotImplementedException();
        }

        public bool SendMessage(string id, string msg)
        {
            throw new NotImplementedException();
        }

        public void VisitUser(string id)
        {
            throw new NotImplementedException();
        }
        public bool Save(object obj)
        {
            try
            {
                var ext = "";
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}ACCOUNTS\\";
                if (this.GetType() == typeof(VKAccount))
                    ext = ".VK";
                Directory.CreateDirectory(path);
                var fileName = $"{path}{CleanFileName(login + "-" + link)}{ext}";
                BinaryFormatter bf = new BinaryFormatter();
                using (Stream stream = new FileStream(fileName,
                    FileMode.Create, FileAccess.Write))
                {
                    bf.Serialize(stream, obj);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //public bool Save(string fileName, object obj)
        //{
        //    try
        //    {
        //        VKAccount forSave = (VKAccount)obj;
        //        BinaryFormatter bf = new BinaryFormatter();
        //        using (Stream stream = new FileStream(fileName,
        //            FileMode.Create, FileAccess.Write))
        //        {
        //            bf.Serialize(stream, bf);
        //            return true;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        public static object Open(string fileName)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (Stream stream = File.OpenRead(fileName))
                {
                    object temp = null;
                    if (Path.GetExtension(fileName) == ".VK")
                        temp = (VKAccount)bf.Deserialize(stream);
                    else
                        temp = (object)bf.Deserialize(stream);
                    return temp;
                }
            }
            catch
            {
                return null;
            }
        }
        public string SendRequest(string req)
        {
            string result = "";
            using (var get = new HttpRequest())
            {
                get.Cookies = (CookieDictionary)cookie;
                get.UserAgent = userAgent;
                HttpResponse resp = get.Post(req);
                result = resp.ToString();//.Substring("<!json>", "-->");
            }
            return result;
        }
        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }
    }
}