using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTest.Data
{
    [Serializable]
    public class Dialog
    {
        public string fromId = "";
        public string fromNickName = "";
        public string linkToAvatar = "";
        /// <summary>
        /// Ссылка на профиль, либо на беседу
        /// </summary>
        public string linkToProfile = "";
        public bool online = false;
        public bool isFriend = false;
        public int secuenceNumber = -1;
        public List<Message> messages = new List<Message>();
    }
}
