using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Key_of_Teyvat
{
    public class ServerList
    {
        public static List<ServerListEntity> serverList = new List<ServerListEntity>();
        public static string[] serverName = { "[miHoYo] 天空岛", "[BILIBILI] 世界树" };
        //初始化服务器列表
        public static void InitializeServerList()
        {
            //加入登录服务器选项 天空岛
            serverList.Add(new ServerListEntity(0, "mihoyo", 1, 1));
            //世界树
            serverList.Add(new ServerListEntity(1, "bilibili", 14, 0));
        }

        //public static ServerListEntity GetServerInfo(int channel)
        //{
        //    var model = serverList.Where(c => c.channel == channel);
        //    return model;
        //}
    }
}
