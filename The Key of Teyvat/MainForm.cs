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
        public IniFile software;
        public string authKeyUrl;
        public IniFile iniLauncher;
        public IniFile iniGame;
        public List<ServerList> serverList = new List<ServerList>();
        public MainForm()
        {
            InitializeComponent();

            LinkLabel_WebSite.Links.Add(3, 11, "https://ys.nullcraft.org/");
            LinkLabel_WebSite.Links.Add(LinkLabel_WebSite.Text.Length - 4, 4, "https://nullcraft.org/d/20");
            LinkLabel_JoinUs.Links.Add(0, LinkLabel_JoinUs.Text.Length, "https://jq.qq.com/?_wv=1027&k=uZdeXKvr");
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
        private void MainForm_Load(object sender, EventArgs e)
        {
            //下个版本待办:
            //1.游戏路径的保存，这样后需就不需要每次打开都寻找了。 已创建好 public IniFile software; 后续存储本地config.ini
            //2.或许会发现什么奇奇怪怪的BUG吧。。
            //3.补充一些注释。

            if (MessageBox.Show("使用前须知\n本软件目前主要已有2大功能，[祈愿AuthKey获取]、[游戏登录服务器切换]\n\n其中功能均为代替手动实现，并且在对应页面提供了手动操作流程超链接。\n本工具不涉及任何额外功能，miHoYo官方也从未正式说明修改登录服务器是否会导致封号问题。\n\n本工具代码全部托管至Github开源，可自行下载编译。\n\n如不放心可点击 [取消] 关闭软件。\n\n自己玩没意思？一起联机锄大地吧！提瓦特厨神交流群 [711723320]", "声明", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }

            //天空岛
            serverList.Add(new ServerList(0,"mihoyo","1","1"));
            //世界树
            serverList.Add(new ServerList(1,"bilibili", "14", "0"));

            //设置authkey路径
            authKeyUrl = @"C:\Users\" + Environment.UserName + @"\AppData\LocalLow\miHoYo\原神\output_log.txt";

            TextBox_AuthKey.AppendText("获取说明:打开游戏 > 进入祈愿 > 点击历史记录 > 返回此软件点击获取AuthKey\r\n");
            TextBox_AuthKey.AppendText("文件路径:" + authKeyUrl + "\r\n");

            if (File.Exists(authKeyUrl))
            {
                TextBox_AuthKey.AppendText("文件状态:存在\r\n");
                TextBox_AuthKey.AppendText("等待用户获取\r\n--------------------------------------------------\r\n");
            }
            else
            {
                TextBox_AuthKey.AppendText("文件状态:不存在\r\n");
            }
            Button_GetAuthKey.Enabled = File.Exists(authKeyUrl);

            ReadServer();
        }

        private void ReadServer()
        {
            if (File.Exists(TextBox_Path_Launcher.Text) && File.Exists(TextBox_Path_Game.Text))
            {
                string luancherConfig = Path.GetDirectoryName(TextBox_Path_Launcher.Text) + @"\config.ini";
                string gameConfig = Path.GetDirectoryName(TextBox_Path_Game.Text) + @"\config.ini";
                iniLauncher = new IniFile(luancherConfig);
                iniGame = new IniFile(gameConfig);

                ServerList sl = serverList.Find(delegate (ServerList s) { return s.cps == iniGame.ReadValue("General", "cps") || s.channel == iniGame.ReadValue("General", "channel"); });
                ComboBox_Server_Name.SelectedIndex = sl.id;
                Label_Server_Type.Text = "当前登录服务器:"+ ComboBox_Server_Name.Text;

                ComboBox_Server_Name.Enabled = true;
                Button_Switch_Server.Enabled = true;
                Button_GameRun_Direct.Enabled = true;
                Button_GameRun_Normal.Enabled = true;
            }
            else
            {
                TextBox_Path_Launcher.Enabled = false;
                TextBox_Path_Game.Enabled = false;
            }
        }

        private void SwitchServer(int type)
        {
            ServerList sl = serverList.Find(delegate (ServerList s) { return s.id == type; });

            iniLauncher.WriteValue("launcher", "cps", sl.cps);
            iniLauncher.WriteValue("launcher", "channel", sl.channel);
            iniLauncher.WriteValue("launcher", "sub_channel", sl.sub_channel);

            iniGame.WriteValue("General", "cps", sl.cps);
            iniGame.WriteValue("General", "channel", sl.channel);
            iniGame.WriteValue("General", "sub_channel", sl.sub_channel);

            ReadServer();
        }

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

        private void Button_GetAuthKey_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(authKeyUrl, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            try
            {
                TextBox_AuthKey.AppendText(GetMiddleStr(sr.ReadToEnd(), "&authkey=", "&game_biz=hk4e_cn"));
                TextBox_AuthKey.AppendText("\r\n--------------------------------------------------\r\n");
            }
            catch (Exception ex)
            {
                TextBox_AuthKey.AppendText("\r\n==============================\r\n");
                TextBox_AuthKey.AppendText("获取AuthKey失败，请尝试手动获取\r\n错误信息:\r\n" + ex);
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
            if (!string.IsNullOrEmpty(TextBox_Path_Launcher.Text) && File.Exists(Path.GetDirectoryName(TextBox_Path_Launcher.Text)+ @"\Genshin Impact Game\YuanShen.exe"))
            {
                TextBox_Path_Game.Text = Path.GetDirectoryName(TextBox_Path_Launcher.Text) + @"\Genshin Impact Game\YuanShen.exe";
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
            ReadServer();
        }

        private void Button_GameRun_Direct_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox_Path_Game.Text))
            {
                Process.Start(TextBox_Path_Game.Text);
            }
        }
        private void Button_GameRun_Normal_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox_Path_Launcher.Text))
            {
                Process.Start(TextBox_Path_Launcher.Text);
            }
        }

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
    }
}
