using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace The_Key_of_Teyvat
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] Args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 检查参数
            for (int intArgIndex = 0; intArgIndex < Args.Length; intArgIndex++)
            {
                MessageBox.Show(Args[intArgIndex]);
                Console.WriteLine(Args[intArgIndex]);
                // 检查是否需要输出日志文件
                //if (Args[intArgIndex] == "-log")
                //    CommonVar.OutputLog = true;
            }

            Application.Run(new MainForm());
        }
    }
}
