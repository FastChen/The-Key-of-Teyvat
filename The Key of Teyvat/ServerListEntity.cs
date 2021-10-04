using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Key_of_Teyvat
{
    public class ServerListEntity
    {
        public int  id { get; set; }
        public string cps { get; set; }
        public int channel { get; set; }
        public int sub_channel { get; set; }

        public ServerListEntity(int _id, string _cps, int _channel, int _sub_channel)
        {
            id = _id;
            cps = _cps;
            channel = _channel;
            sub_channel = _sub_channel;
        }
    }
}
