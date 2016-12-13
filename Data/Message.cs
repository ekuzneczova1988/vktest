using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKTest.Data
{
    [Serializable]
    public class Message
    {
        /// <summary>
        /// id сообщения
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// id пользователя написавшего сообщение
        /// </summary>
        public int idContact { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime date { get; set; }
        public bool opened { get; set; }
        /// <summary>
        /// Входящее если true
        /// </summary>
        public bool incoming { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// Картинки и тд
        /// </summary>
        public string media { get; set; }
    }
}
