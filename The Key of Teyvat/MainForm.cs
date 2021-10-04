using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace The_Key_of_Teyvat
{
    public partial class MainForm : Form
    {
        //为了防止用户无法区分游戏和软件的config.ini，软件改为setting.ini。（苦笑）
        public IniFile software = new IniFile(Environment.CurrentDirectory+@"\setting.ini");
        public static IniFile iniLauncher;
        public static IniFile iniGame;

        public MainForm()
        {
            InitializeComponent();

            ServerList.InitializeServerList();
            ComboBox_Server_Name.Items.AddRange(ServerList.serverName);
            //给LinkLabel上链接。
            LinkLabel_WebSite.Links.Add(3, 11, "https://ys.nullcraft.org/");
            LinkLabel_WebSite.Links.Add(LinkLabel_WebSite.Text.Length - 4, 4, "https://nullcraft.org/d/20");
            LinkLabel_JoinUs.Links.Add(0, LinkLabel_JoinUs.Text.Length, "https://jq.qq.com/?_wv=1027&k=uZdeXKvr");
            LinkLabel_Donate.Links.Add(5,4, "https://docs.nullcraft.org/donate");
            LinkLabel_Donate.Links.Add(LinkLabel_Donate.Text.Length - 3, 3, "https://afdian.net/@fastchen");
        }

        private void ReadSoftwareConfig()
        {
            //从配置文件中读取上次选择的路径。
            TextBox_Path_Launcher.Text = software.ReadValue("Path", "Launcher");
            TextBox_Path_Game.Text = software.ReadValue("Path", "Game");
            TextBox_Path_AuthKey.Text = !File.Exists(software.ReadValue("Path", "AuthKey")) ? @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\miHoYo\原神\output_log.txt" : software.ReadValue("Path", "AuthKey");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("使用前须知\n本软件目前主要已有2大功能，[祈愿AuthKey获取]、[游戏登录服务器切换]\n\n其中功能均为代替手动实现，并且在对应页面提供了手动操作流程超链接。\n本工具不涉及任何额外功能，miHoYo官方也从未正式说明修改登录服务器是否会导致封号问题。\n\n本工具代码全部托管至Github开源，可自行下载编译。\n\n如不放心可点击 [取消] 关闭软件。\n\n自己玩没意思？一起联机锄大地吧！提瓦特厨神交流群 [711723320]", "声明", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
            Label_Version.Text = "当前版本:v" + Application.ProductVersion;

            //读取软件config
            ReadSoftwareConfig();

            ////加入登录服务器选项 天空岛
            //serverList.Add(new ServerListEntity(0,"mihoyo","1","1"));
            ////世界树
            //serverList.Add(new ServerListEntity(1,"bilibili", "14", "0"));

            //读取当前登录服务器
            ReadServer();
            //检测Authkey是否存在
            CheckAuthKey();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NotifyIcon.Icon = null;
            Environment.Exit(0);
        }

        /// <summary>
        /// 获取文本中间
        /// </summary>
        /// <param name="fullStr">全文本</param>
        /// <param name="preStr">前文本</param>
        /// <param name="nextStr">后文本</param>
        /// <returns></returns>
        public static string GetMiddleStr(string fullStr, string preStr, string nextStr)
        {
            string tempStr = fullStr.Substring(fullStr.IndexOf(preStr) + preStr.Length);
            tempStr = tempStr.Substring(0, tempStr.IndexOf(nextStr));
            return tempStr;
        }

        private void CheckAuthKey()
        {
            TextBox_AuthKey.Text = string.Empty;
            //添加基本信息到AuthKey说明。
            TextBox_AuthKey.AppendText("获取说明:打开游戏 > 进入祈愿 > 点击历史记录 > 返回此软件点击获取AuthKey\r\n");
            TextBox_AuthKey.AppendText("文件路径:" + TextBox_Path_AuthKey.Text + "\r\n");
            if (File.Exists(TextBox_Path_AuthKey.Text))
            {
                TextBox_AuthKey.AppendText("文件状态:存在\r\n");
                TextBox_AuthKey.AppendText("等待用户获取\r\n--------------------------------------------------\r\n");
            }
            else
            {
                TextBox_AuthKey.AppendText("文件状态:不存在，请手动定位文件。\r\n");
            }
            Button_GetAuthKey.Enabled = File.Exists(TextBox_Path_AuthKey.Text);
        }

        private void ReadServer()
        {
            if (File.Exists(TextBox_Path_Launcher.Text) && File.Exists(TextBox_Path_Game.Text))
            {
                iniLauncher = new IniFile(Path.GetDirectoryName(TextBox_Path_Launcher.Text) + @"\config.ini"); //启动器配置文件
                iniGame = new IniFile(Path.GetDirectoryName(TextBox_Path_Game.Text) + @"\config.ini"); //游戏配置文件

                ServerListEntity sl = ServerList.serverList.Find(delegate (ServerListEntity s) { return s.cps == iniGame.ReadValue("General", "cps") || s.channel ==Convert.ToInt32(iniGame.ReadValue("General", "channel")); });
                ComboBox_Server_Name.SelectedIndex = sl.id;
                Label_Server_Type.Text = "当前登录服务器:"+ ComboBox_Server_Name.Text;

                //做一个向上兼容，如果2.0就一直再官服玩更新2.1可能无SDKDLL，那么就写出 判断当前为B服而且文件还不存在时则写入一个SDK。
                if (sl.cps == "bilibili" && sl.channel == 14 && !File.Exists(Path.GetDirectoryName(TextBox_Path_Game.Text) + @"\YuanShen_Data\Plugins\PCGameSDK.dll"))
                {
                    ExportGameSDKDLL(sl.cps == "bilibili" && sl.channel == 14);
                }

                ComboBox_Server_Name.Enabled = true;
                Button_Switch_Server.Enabled = true;
                Button_GameRun_Direct.Enabled = true;
                Button_GameRun_Normal.Enabled = true;
            }
        }
        //2.1 B服新增一个DLL才能正常登录使用，此DLL已内嵌资源中，
        //以下DLL信息，由本人写的 哈希 Hash 进行获取 https://nullcraft.org/d/12
        //数字签名公司:上海宽娱数码科技有限公司
        //文件大小:5454624 字节
        //创建日期:2021/8/2 10:21:54 
        //————————————————————————
        //MD5:81ee1d7755b8611ac98b334e0bbcd3d2
        //SHA1:c0ff9859672c9ad40eeb22da7b0a5a251e4a16cc
        //SHA256:88030b01a9e2b4a1032dea3fa8a17df30c8aeb5a7614f1cfa02c898c5b4371ea
        //SHA384:c5c19c9686d75e07fa7a44d25161d22580a1e61df141bec0bb71f01dc70d52712a078521868c709efa5b5bba360c17c1
        //SHA512:2ca5c837abac53cc7c8459fd5500a8f47f35239118b05f9380b7d96ef6b80530fe2d47911c6cb1429a6c89318d3d7e6a09e799f4e15b1560741a962d9b71ed14

        private void ExportGameSDKDLL(bool needexport)
        {
            string strPath = Path.GetDirectoryName(TextBox_Path_Game.Text) + @"\YuanShen_Data\Plugins\PCGameSDK.dll";
            //是否需要导出DLL，目前仅B服需要，而且签名也是B站公司，所以官服就删掉此DLL以防出现问题。
            if (!needexport)
            {
                if (File.Exists(strPath))
                {
                    File.Delete(strPath);
                }
            }
            else
            {
                byte[] byDll = Properties.Resources.PCGameSDK;
                using (FileStream fs = new FileStream(strPath, FileMode.Create))
                {
                    fs.Write(byDll, 0, byDll.Length);
                }
            }
        }
        //切换服务器
        private void SwitchServer(int id)
        {
            ServerListEntity serverListEntity = ServerList.serverList.Find(delegate (ServerListEntity s) { return s.id == id; });
            //写出启动器配置
            iniLauncher.WriteValue("launcher", "cps", serverListEntity.cps);
            iniLauncher.WriteValue("launcher", "channel", serverListEntity.channel.ToString());
            iniLauncher.WriteValue("launcher", "sub_channel", serverListEntity.sub_channel.ToString());
            //写出游戏配置
            iniGame.WriteValue("General", "cps", serverListEntity.cps);
            iniGame.WriteValue("General", "channel", serverListEntity.channel.ToString());
            iniGame.WriteValue("General", "sub_channel", serverListEntity.sub_channel.ToString());
            //导出B服所需DLL
            ExportGameSDKDLL(serverListEntity.cps == "bilibili" && serverListEntity.channel == 14);
            //设置完毕读取状态
            ReadServer();
            //通知
            NotifyIcon.ShowBalloonTip(5,null,"已切换至 "+ ComboBox_Server_Name.Items[serverListEntity.id]+"\n如登录未更改请尝试以管理员运行程序后再试",ToolTipIcon.None);
        }

        //封装FileDialog重复调用
        private string FindFile(string filter, string title)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = filter;
            fileDialog.Title = title;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            return "";
        }

        private void Button_FindPath_AuthKey_Click(object sender, EventArgs e)
        {
            string authPath = FindFile("output_log|output_log.txt", @"通常存在于 C:\Users\你的用户名\AppData\LocalLow\miHoYo\原神\ 下");

            if (string.IsNullOrEmpty(authPath))
            {
                return;
            }
            else
            {
                TextBox_Path_AuthKey.Text = authPath;
                software.WriteValue("Path", "AuthKey", TextBox_Path_AuthKey.Text);
            }
            CheckAuthKey();
        }

        private void Button_GetAuthKey_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(TextBox_Path_AuthKey.Text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            try
            {
                TextBox_AuthKey.AppendText(GetMiddleStr(sr.ReadToEnd(), "&authkey=", "&game_biz=hk4e_cn"));
                TextBox_AuthKey.AppendText("\r\n--------------------------------------------------\r\n");
                NotifyIcon.ShowBalloonTip(5,null, "AuthKey获取成功\n可以点击[万能派蒙祈愿数据可视化]在线查看祈愿数据", ToolTipIcon.None);
            }
            catch (Exception ex)
            {
                TextBox_AuthKey.AppendText("\r\n==============================\r\n");
                TextBox_AuthKey.AppendText("获取AuthKey失败，请尝试手动获取\r\n错误信息:\r\n" + ex);
                NotifyIcon.ShowBalloonTip(5, "AuthKey获取失败", "请 打开游戏 > 进入祈愿 > 点击历史记录\n然后返回此软件点击获取AuthKey", ToolTipIcon.Warning);
            }
        }

        private void Button_Switch_Server_Click(object sender, EventArgs e)
        {
            if (ComboBox_Server_Name.SelectedIndex != -1)
            {
                SwitchServer(ComboBox_Server_Name.SelectedIndex);
            }
        }

        private void Button_FindPath_Launcher_Click(object sender, EventArgs e)
        {
            TextBox_Path_Launcher.Text = FindFile("原神启动器|launcher.exe", "请选择原神启动器文件 launcher.exe");
            if (!string.IsNullOrEmpty(TextBox_Path_Launcher.Text) && !File.Exists(Path.GetDirectoryName(TextBox_Path_Launcher.Text) + @"\config.ini"))
            {
                MessageBox.Show("启动器配置文件不存在。","文件丢失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            software.WriteValue("Path", "Launcher", TextBox_Path_Launcher.Text);
            if (!string.IsNullOrEmpty(TextBox_Path_Launcher.Text) && File.Exists(Path.GetDirectoryName(TextBox_Path_Launcher.Text)+ @"\Genshin Impact Game\YuanShen.exe"))
            {
                TextBox_Path_Game.Text = Path.GetDirectoryName(TextBox_Path_Launcher.Text) + @"\Genshin Impact Game\YuanShen.exe";
                software.WriteValue("Path", "Game", TextBox_Path_Game.Text);
                ReadServer();
            }
        }

        private void Button_FindPath_Game_Click(object sender, EventArgs e)
        {
            TextBox_Path_Game.Text = FindFile("原神本体|YuanShen.exe", "请选择其目录含有 YuanShen_Data 同级文件夹 下的 原神主体文件 YuanShen.exe");
            if (!string.IsNullOrEmpty(TextBox_Path_Game.Text) && !File.Exists(Path.GetDirectoryName(TextBox_Path_Game.Text) + @"\config.ini"))
            {
                MessageBox.Show("游戏本体配置文件不存在。", "文件丢失", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            software.WriteValue("Path", "Game", TextBox_Path_Game.Text);
            ReadServer();
        }

        private void Button_GameRun_Direct_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox_Path_Game.Text))
            {
                if (MessageBox.Show("直接启动原神可能会出现数据异常、无法获取小更新等情况，建议优先使用 启动器启动。\r\n\r\n点击 [确定] 继续启动游戏", "提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Process.Start(TextBox_Path_Game.Text);
                }
            }
        }
        private void Button_GameRun_Normal_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox_Path_Launcher.Text))
            {
                Process.Start(TextBox_Path_Launcher.Text);
            }
        }

        //下面就是一些LinkLabel的点击跳转，无用。
        private void LinkLabel_JoinUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel_JoinUs.Links[LinkLabel_JoinUs.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                Process.Start(targetUrl);
            }
        }

        private void LinkLabel_WebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel_WebSite.Links[LinkLabel_WebSite.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                Process.Start(targetUrl);
            }
        }

        private void LinkLabel_SwitchServer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://nullcraft.org/d/20");
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FastChen/The-Key-of-Teyvat");
        }

        private void LinkLabel_Donate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel_Donate.Links[LinkLabel_Donate.Links.IndexOf(e.Link)].Visited = true;
            string targetUrl = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                Process.Start(targetUrl);
            }
        }

    }
}
