using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTest.Data
{
    [Serializable]
    public class Dialog
    {
        public string fromId { get; set; }
        public string fromNickName { get; set; }
        public string linkToAvatar { get; set; }
        /// <summary>
        /// Ссылка на профиль, либо на беседу
        /// </summary>
        public string linkToProfile { get; set; }
        public bool online { get; set; }
        public bool isFriend { get; set; }
        public int secuenceNumber { get; set; }
        public int unreadMsg { get; set; }
        public string lastMessage { get; set; }
        [Display (AutoGenerateField = false)]
        public List<Message> messages
        {
            get
            {
                if (_messages == null)
                    return null;
                return _messages.OrderBy(o=>o.date).ToList();
            }

            set
            {
                _messages = value;
            }
        }
        public List<Message> _messages = new List<Message>();
        public Dialog()
        {
          //  messages = new List<Message>();
        }

    }
}
