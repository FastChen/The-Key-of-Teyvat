
namespace The_Key_of_Teyvat
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_AuthKey = new System.Windows.Forms.TabPage();
            this.Button_FindPath_AuthKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_Path_AuthKey = new System.Windows.Forms.TextBox();
            this.LinkLabel_WebSite = new System.Windows.Forms.LinkLabel();
            this.Button_GetAuthKey = new System.Windows.Forms.Button();
            this.TextBox_AuthKey = new System.Windows.Forms.TextBox();
            this.TabPage_ServerSwitch = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.LinkLabel_SwitchServer = new System.Windows.Forms.LinkLabel();
            this.Button_GameRun_Direct = new System.Windows.Forms.Button();
            this.Button_GameRun_Normal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Label_Server_Type = new System.Windows.Forms.Label();
            this.Button_Switch_Server = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_Server_Name = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Button_FindPath_Game = new System.Windows.Forms.Button();
            this.Button_FindPath_Launcher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Path_Game = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Path_Launcher = new System.Windows.Forms.TextBox();
            this.TabPage_About = new System.Windows.Forms.TabPage();
            this.LinkLabel_Donate = new System.Windows.Forms.LinkLabel();
            this.Label_Version = new System.Windows.Forms.Label();
            this.LinkLabel_JoinUs = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControl_Main.SuspendLayout();
            this.TabPage_AuthKey.SuspendLayout();
            this.TabPage_ServerSwitch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabPage_About.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_AuthKey);
            this.TabControl_Main.Controls.Add(this.TabPage_ServerSwitch);
            this.TabControl_Main.Controls.Add(this.TabPage_About);
            this.TabControl_Main.Location = new System.Drawing.Point(8, 8);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(610, 306);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_AuthKey
            // 
            this.TabPage_AuthKey.Controls.Add(this.Button_FindPath_AuthKey);
            this.TabPage_AuthKey.Controls.Add(this.label6);
            this.TabPage_AuthKey.Controls.Add(this.TextBox_Path_AuthKey);
            this.TabPage_AuthKey.Controls.Add(this.LinkLabel_WebSite);
            this.TabPage_AuthKey.Controls.Add(this.Button_GetAuthKey);
            this.TabPage_AuthKey.Controls.Add(this.TextBox_AuthKey);
            this.TabPage_AuthKey.Location = new System.Drawing.Point(4, 26);
            this.TabPage_AuthKey.Name = "TabPage_AuthKey";
            this.TabPage_AuthKey.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_AuthKey.Size = new System.Drawing.Size(602, 276);
            this.TabPage_AuthKey.TabIndex = 0;
            this.TabPage_AuthKey.Text = "AuthKey获取";
            this.TabPage_AuthKey.UseVisualStyleBackColor = true;
            // 
            // Button_FindPath_AuthKey
            // 
            this.Button_FindPath_AuthKey.Location = new System.Drawing.Point(558, 7);
            this.Button_FindPath_AuthKey.Name = "Button_FindPath_AuthKey";
            this.Button_FindPath_AuthKey.Size = new System.Drawing.Size(38, 25);
            this.Button_FindPath_AuthKey.TabIndex = 7;
            this.Button_FindPath_AuthKey.Text = "...";
            this.Button_FindPath_AuthKey.UseVisualStyleBackColor = true;
            this.Button_FindPath_AuthKey.Click += new System.EventHandler(this.Button_FindPath_AuthKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "AuthKey目录:";
            // 
            // TextBox_Path_AuthKey
            // 
            this.TextBox_Path_AuthKey.Enabled = false;
            this.TextBox_Path_AuthKey.Location = new System.Drawing.Point(91, 8);
            this.TextBox_Path_AuthKey.Name = "TextBox_Path_AuthKey";
            this.TextBox_Path_AuthKey.Size = new System.Drawing.Size(462, 23);
            this.TextBox_Path_AuthKey.TabIndex = 5;
            // 
            // LinkLabel_WebSite
            // 
            this.LinkLabel_WebSite.AutoSize = true;
            this.LinkLabel_WebSite.Location = new System.Drawing.Point(256, 246);
            this.LinkLabel_WebSite.Name = "LinkLabel_WebSite";
            this.LinkLabel_WebSite.Size = new System.Drawing.Size(234, 17);
            this.LinkLabel_WebSite.TabIndex = 3;
            this.LinkLabel_WebSite.TabStop = true;
            this.LinkLabel_WebSite.Text = "前往 万能派蒙祈愿数据可视化 && 手动获取";
            this.LinkLabel_WebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_WebSite_LinkClicked);
            // 
            // Button_GetAuthKey
            // 
            this.Button_GetAuthKey.Location = new System.Drawing.Point(496, 239);
            this.Button_GetAuthKey.Name = "Button_GetAuthKey";
            this.Button_GetAuthKey.Size = new System.Drawing.Size(100, 32);
            this.Button_GetAuthKey.TabIndex = 1;
            this.Button_GetAuthKey.Text = "获取AuthKey";
            this.Button_GetAuthKey.UseVisualStyleBackColor = true;
            this.Button_GetAuthKey.Click += new System.EventHandler(this.Button_GetAuthKey_Click);
            // 
            // TextBox_AuthKey
            // 
            this.TextBox_AuthKey.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_AuthKey.Location = new System.Drawing.Point(5, 39);
            this.TextBox_AuthKey.Multiline = true;
            this.TextBox_AuthKey.Name = "TextBox_AuthKey";
            this.TextBox_AuthKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_AuthKey.Size = new System.Drawing.Size(590, 193);
            this.TextBox_AuthKey.TabIndex = 0;
            // 
            // TabPage_ServerSwitch
            // 
            this.TabPage_ServerSwitch.Controls.Add(this.label5);
            this.TabPage_ServerSwitch.Controls.Add(this.LinkLabel_SwitchServer);
            this.TabPage_ServerSwitch.Controls.Add(this.Button_GameRun_Direct);
            this.TabPage_ServerSwitch.Controls.Add(this.Button_GameRun_Normal);
            this.TabPage_ServerSwitch.Controls.Add(this.groupBox2);
            this.TabPage_ServerSwitch.Controls.Add(this.groupBox1);
            this.TabPage_ServerSwitch.Location = new System.Drawing.Point(4, 26);
            this.TabPage_ServerSwitch.Name = "TabPage_ServerSwitch";
            this.TabPage_ServerSwitch.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_ServerSwitch.Size = new System.Drawing.Size(602, 276);
            this.TabPage_ServerSwitch.TabIndex = 1;
            this.TabPage_ServerSwitch.Text = "登录服务器切换";
            this.TabPage_ServerSwitch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 51);
            this.label5.TabIndex = 6;
            this.label5.Text = "*修改登录服务器时需完全退出原神，以防修改失败。\r\n*2.1版本B服需要额外文件才能正常运行，目前切换至B服会自动释放所需文件。\r\n*修改无效请尝试 右键软件->" +
    "以管理员身份运行";
            // 
            // LinkLabel_SwitchServer
            // 
            this.LinkLabel_SwitchServer.AutoSize = true;
            this.LinkLabel_SwitchServer.Location = new System.Drawing.Point(305, 246);
            this.LinkLabel_SwitchServer.Name = "LinkLabel_SwitchServer";
            this.LinkLabel_SwitchServer.Size = new System.Drawing.Size(56, 17);
            this.LinkLabel_SwitchServer.TabIndex = 5;
            this.LinkLabel_SwitchServer.TabStop = true;
            this.LinkLabel_SwitchServer.Text = "手动修改";
            this.LinkLabel_SwitchServer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_SwitchServer_LinkClicked);
            // 
            // Button_GameRun_Direct
            // 
            this.Button_GameRun_Direct.Enabled = false;
            this.Button_GameRun_Direct.Location = new System.Drawing.Point(367, 239);
            this.Button_GameRun_Direct.Name = "Button_GameRun_Direct";
            this.Button_GameRun_Direct.Size = new System.Drawing.Size(101, 31);
            this.Button_GameRun_Direct.TabIndex = 4;
            this.Button_GameRun_Direct.Text = "直接启动游戏";
            this.ToolTip.SetToolTip(this.Button_GameRun_Direct, "跳过原神启动器，直接运行游戏，缺点如有更新无法获取或出现数据异常等问题。");
            this.Button_GameRun_Direct.UseVisualStyleBackColor = true;
            this.Button_GameRun_Direct.Click += new System.EventHandler(this.Button_GameRun_Direct_Click);
            // 
            // Button_GameRun_Normal
            // 
            this.Button_GameRun_Normal.Enabled = false;
            this.Button_GameRun_Normal.Location = new System.Drawing.Point(474, 239);
            this.Button_GameRun_Normal.Name = "Button_GameRun_Normal";
            this.Button_GameRun_Normal.Size = new System.Drawing.Size(122, 31);
            this.Button_GameRun_Normal.TabIndex = 3;
            this.Button_GameRun_Normal.Text = "[推荐] 启动器启动";
            this.ToolTip.SetToolTip(this.Button_GameRun_Normal, "通过原神启动器进行启动游戏。\r\n如游戏有更新则可获取更新并下载。");
            this.Button_GameRun_Normal.UseVisualStyleBackColor = true;
            this.Button_GameRun_Normal.Click += new System.EventHandler(this.Button_GameRun_Normal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label_Server_Type);
            this.groupBox2.Controls.Add(this.Button_Switch_Server);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ComboBox_Server_Name);
            this.groupBox2.Location = new System.Drawing.Point(6, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 58);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "切换游戏服务器";
            // 
            // Label_Server_Type
            // 
            this.Label_Server_Type.AutoSize = true;
            this.Label_Server_Type.ForeColor = System.Drawing.Color.Gray;
            this.Label_Server_Type.Location = new System.Drawing.Point(327, 27);
            this.Label_Server_Type.Name = "Label_Server_Type";
            this.Label_Server_Type.Size = new System.Drawing.Size(167, 17);
            this.Label_Server_Type.TabIndex = 6;
            this.Label_Server_Type.Text = "当前登录服务器:请先选择目录";
            // 
            // Button_Switch_Server
            // 
            this.Button_Switch_Server.Enabled = false;
            this.Button_Switch_Server.Location = new System.Drawing.Point(231, 22);
            this.Button_Switch_Server.Name = "Button_Switch_Server";
            this.Button_Switch_Server.Size = new System.Drawing.Size(90, 27);
            this.Button_Switch_Server.TabIndex = 5;
            this.Button_Switch_Server.Text = "切换服务器";
            this.Button_Switch_Server.UseVisualStyleBackColor = true;
            this.Button_Switch_Server.Click += new System.EventHandler(this.Button_Switch_Server_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "选择服务器:";
            // 
            // ComboBox_Server_Name
            // 
            this.ComboBox_Server_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Server_Name.Enabled = false;
            this.ComboBox_Server_Name.FormattingEnabled = true;
            this.ComboBox_Server_Name.Location = new System.Drawing.Point(85, 23);
            this.ComboBox_Server_Name.Name = "ComboBox_Server_Name";
            this.ComboBox_Server_Name.Size = new System.Drawing.Size(140, 25);
            this.ComboBox_Server_Name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_FindPath_Game);
            this.groupBox1.Controls.Add(this.Button_FindPath_Launcher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBox_Path_Game);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBox_Path_Launcher);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定位游戏目录";
            // 
            // Button_FindPath_Game
            // 
            this.Button_FindPath_Game.Location = new System.Drawing.Point(542, 51);
            this.Button_FindPath_Game.Name = "Button_FindPath_Game";
            this.Button_FindPath_Game.Size = new System.Drawing.Size(38, 25);
            this.Button_FindPath_Game.TabIndex = 5;
            this.Button_FindPath_Game.Text = "...";
            this.Button_FindPath_Game.UseVisualStyleBackColor = true;
            this.Button_FindPath_Game.Click += new System.EventHandler(this.Button_FindPath_Game_Click);
            // 
            // Button_FindPath_Launcher
            // 
            this.Button_FindPath_Launcher.Location = new System.Drawing.Point(542, 22);
            this.Button_FindPath_Launcher.Name = "Button_FindPath_Launcher";
            this.Button_FindPath_Launcher.Size = new System.Drawing.Size(38, 25);
            this.Button_FindPath_Launcher.TabIndex = 4;
            this.Button_FindPath_Launcher.Text = "...";
            this.Button_FindPath_Launcher.UseVisualStyleBackColor = true;
            this.Button_FindPath_Launcher.Click += new System.EventHandler(this.Button_FindPath_Launcher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "游戏目录:";
            // 
            // TextBox_Path_Game
            // 
            this.TextBox_Path_Game.Enabled = false;
            this.TextBox_Path_Game.Location = new System.Drawing.Point(85, 52);
            this.TextBox_Path_Game.Name = "TextBox_Path_Game";
            this.TextBox_Path_Game.Size = new System.Drawing.Size(451, 23);
            this.TextBox_Path_Game.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "启动器目录:";
            // 
            // TextBox_Path_Launcher
            // 
            this.TextBox_Path_Launcher.Enabled = false;
            this.TextBox_Path_Launcher.Location = new System.Drawing.Point(85, 23);
            this.TextBox_Path_Launcher.Name = "TextBox_Path_Launcher";
            this.TextBox_Path_Launcher.Size = new System.Drawing.Size(451, 23);
            this.TextBox_Path_Launcher.TabIndex = 0;
            // 
            // TabPage_About
            // 
            this.TabPage_About.Controls.Add(this.LinkLabel_Donate);
            this.TabPage_About.Controls.Add(this.Label_Version);
            this.TabPage_About.Controls.Add(this.LinkLabel_JoinUs);
            this.TabPage_About.Controls.Add(this.label4);
            this.TabPage_About.Location = new System.Drawing.Point(4, 26);
            this.TabPage_About.Name = "TabPage_About";
            this.TabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_About.Size = new System.Drawing.Size(602, 276);
            this.TabPage_About.TabIndex = 2;
            this.TabPage_About.Text = "关于软件";
            this.TabPage_About.UseVisualStyleBackColor = true;
            // 
            // LinkLabel_Donate
            // 
            this.LinkLabel_Donate.AutoSize = true;
            this.LinkLabel_Donate.Location = new System.Drawing.Point(259, 246);
            this.LinkLabel_Donate.Name = "LinkLabel_Donate";
            this.LinkLabel_Donate.Size = new System.Drawing.Size(155, 17);
            this.LinkLabel_Donate.TabIndex = 3;
            this.LinkLabel_Donate.TabStop = true;
            this.LinkLabel_Donate.Text = "支持我们 赞助我们 | 爱发电";
            this.LinkLabel_Donate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Donate_LinkClicked);
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.ForeColor = System.Drawing.Color.Gray;
            this.Label_Version.Location = new System.Drawing.Point(10, 246);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(104, 17);
            this.Label_Version.TabIndex = 2;
            this.Label_Version.Text = "当前版本:读取中...";
            // 
            // LinkLabel_JoinUs
            // 
            this.LinkLabel_JoinUs.AutoSize = true;
            this.LinkLabel_JoinUs.Location = new System.Drawing.Point(420, 246);
            this.LinkLabel_JoinUs.Name = "LinkLabel_JoinUs";
            this.LinkLabel_JoinUs.Size = new System.Drawing.Size(175, 17);
            this.LinkLabel_JoinUs.TabIndex = 1;
            this.LinkLabel_JoinUs.TabStop = true;
            this.LinkLabel_JoinUs.Text = "提瓦特厨神交流群[711723320]";
            this.LinkLabel_JoinUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_JoinUs_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 102);
            this.label4.TabIndex = 0;
            this.label4.Text = "本软件目前为临时作品，其中代码，逻辑均未作任何优化，只做了基本功能。后续将持续进行优化\r\n\r\n软件作者:快辰\r\n一起联机锄大地:提瓦特厨神交流群[71172332" +
    "0]\r\n\r\n偶尔做些小软件什么的。本软件主要是配合我另一个项目 https://ys.nullcraft.org - 万能派蒙";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.StatusStrip.Location = new System.Drawing.Point(0, 321);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(624, 26);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 21);
            this.toolStripStatusLabel1.Text = "Tips:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(500, 21);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "本工具实现的功能均为代替手动，每个功能页都提供手动实现方法。";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(0, 3, -10, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(80, 21);
            this.toolStripStatusLabel3.Text = "本工具已开源";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "NotifyIcon";
            this.NotifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 347);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TabControl_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提瓦特之匙 - The Key of Teyvat - FastChen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_AuthKey.ResumeLayout(false);
            this.TabPage_AuthKey.PerformLayout();
            this.TabPage_ServerSwitch.ResumeLayout(false);
            this.TabPage_ServerSwitch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabPage_About.ResumeLayout(false);
            this.TabPage_About.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_AuthKey;
        private System.Windows.Forms.TabPage TabPage_ServerSwitch;
        private System.Windows.Forms.TabPage TabPage_About;
        private System.Windows.Forms.Button Button_GetAuthKey;
        private System.Windows.Forms.TextBox TextBox_AuthKey;
        private System.Windows.Forms.LinkLabel LinkLabel_WebSite;
        private System.Windows.Forms.TextBox TextBox_Path_Launcher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Path_Game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_FindPath_Launcher;
        private System.Windows.Forms.Button Button_FindPath_Game;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ComboBox_Server_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Switch_Server;
        private System.Windows.Forms.Label Label_Server_Type;
        private System.Windows.Forms.Button Button_GameRun_Direct;
        private System.Windows.Forms.Button Button_GameRun_Normal;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LinkLabel_JoinUs;
        private System.Windows.Forms.LinkLabel LinkLabel_SwitchServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.LinkLabel LinkLabel_Donate;
        private System.Windows.Forms.Button Button_FindPath_AuthKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_Path_AuthKey;
    }
}

