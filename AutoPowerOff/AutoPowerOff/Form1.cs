using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace AutoPowerOff
{
    public partial class Form1 : Form
    {
        int minutes = 0;
        int seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadIni();
        }

        private void loadIni()
        {
            StreamReader sr = new StreamReader(@"minutes.ini", Encoding.GetEncoding("Shift_JIS"));

            string str = sr.ReadToEnd();

            minutes = int.Parse(str);

            sr.Close();

            lblInfo.Text = minutes + "分後にシャットダウン";

            lblCountDown.Text = minutes + ":" + seconds;
        }

        private void myTimer1_Tick(object sender, EventArgs e)
        {
            if(seconds != 0)
            {
                seconds--;
            }
            else if(minutes != 0)
            {
                minutes--;
                seconds = 59;
            }
            else
            {
                execShutdown();
                myTimer1.Stop();
            }

            lblCountDown.Text = minutes + ":" + seconds;
        }

        private void execShutdown()
        {
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            pro.StartInfo.FileName = "shutdown";            // コマンド名
            pro.StartInfo.Arguments = "-s -t 1";               // 引数
            pro.StartInfo.CreateNoWindow = true;            // DOSプロンプトの黒い画面を非表示
            pro.StartInfo.UseShellExecute = false;          // プロセスを新しいウィンドウで起動するか否か
            pro.StartInfo.RedirectStandardOutput = true;    // 標準出力をリダイレクトして取得したい

            pro.Start();

            string output = pro.StandardOutput.ReadToEnd();
        }
    }
}
