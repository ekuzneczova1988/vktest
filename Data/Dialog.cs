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
        string fromId;
        string fromNickName;
        string linkToAvatar;
        bool online;
        List<Message> messages = new List<Message>();
    }
}
