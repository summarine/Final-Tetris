using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sever
{
    public class ScoreMsg
    { 
        //好友姓名
        public string name;
        //好友分数
        public string score;
    }

    public class SocketMessage
    {
        public string et { get; set; }
        public ClientInfo Client { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
