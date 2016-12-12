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
        string id { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        DateTime date { get; set; }
        bool opened { get; set; }
        /// <summary>
        /// Входящее если true
        /// </summary>
        bool incoming { get; set; }
        /// <summary>
        /// Сообщение
        /// </summary>
        string msg { get; set; }
        /// <summary>
        /// Картинки и тд
        /// </summary>
        string media { get; set; }
    }
}
