using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Key_of_Teyvat
{
    public class ServerList
    {
        public int  id { get; set; }
        public string cps { get; set; }
        public string channel { get; set; }
        public string sub_channel { get; set; }

        public ServerList(int _id, string _cps, string _channel, string _sub_channel)
        {
            id = _id;
            cps = _cps;
            channel = _channel;
            sub_channel = _sub_channel;
        }
    }
}
