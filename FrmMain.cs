using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lottery
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002; 

        public string SoftPath = System.IO.Directory.GetCurrentDirectory();
        public string[,] Awardarr = new string[100, 4];  //声明多维数组，用于保存奖项 

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //读取奖项名称
            try
            {                
                this.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\MainBG.jpg");
                BtnIn.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_start.png");
                FileStream fsFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\database\\Award_Config.ini", FileMode.Open);                
                StreamReader srReader = new StreamReader(fsFile);
                //读取文件(读取大文件时，最好不要用此方法)
                srReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string sLine = "";
                int i = 0;
                string strLine = srReader.ReadLine();
                while (strLine != null)
                {
                    if (strLine != "")
                    {
                        string[] sArray = strLine.Split(';');
                        Awardarr[i, 0] = sArray[0]; //奖项名称
                        Awardarr[i, 1] = sArray[1]; //同屏抽奖人数
                        Awardarr[i, 2] = sArray[2]; //背景图片
                        AwardSel.Items.Add(Awardarr[i,0]);
                        strLine = srReader.ReadLine();
                        i++;
                    }
                }                
                srReader.Close();
            }
            catch
            {
                MessageBox.Show("配置文件出错，请联系技术人员");
                System.Environment.Exit(0);
            }
        }
        private void BtnIn_Click(object sender, EventArgs e)
        {
            if (AwardSel.SelectedIndex < 0) return;
            int i = AwardSel.SelectedIndex;
            switch (Awardarr[i, 1])
            {
                case "1":
                    FrmAwardLucky1 Award1 = new FrmAwardLucky1();
                    Award1.PhotoBGImage = "\\images\\" + Awardarr[i, 2];
                    Award1.ShowAward = Awardarr[i, 0];
                    Award1.ShowDialog();
                    break;
                case "5":
                    FrmAwardLucky5 Award5 = new FrmAwardLucky5();
                    Award5.PhotoBGImage = "\\images\\" + Awardarr[i, 2];
                    Award5.ShowAward = Awardarr[i, 0];
                    Award5.ShowDialog();
                    break;
                case "10":
                    FrmAwardLucky10 Award10 = new FrmAwardLucky10();
                    Award10.PhotoBGImage = "\\images\\" + Awardarr[i, 2];
                    Award10.ShowAward = Awardarr[i, 0];
                    Award10.ShowDialog();
                    break;
                case "20":
                    FrmAwardLucky20 Award20 = new FrmAwardLucky20();
                    Award20.PhotoBGImage = "\\images\\" + Awardarr[i, 2];
                    Award20.ShowAward = Awardarr[i, 0];
                    Award20.ShowDialog();
                    break;
                case "100":  //系统设置
                    FrmSetup Frmsetup = new FrmSetup();
                    Frmsetup.ShowDialog();
                    break;
                case "101": //查看奖池
                    FrmSeed FrmSeed = new FrmSeed();
                    FrmSeed.ShowDialog();
                    break;
                case "102": //中奖者名单
                    FrmAwardList FrmAwardList = new FrmAwardList();
                    FrmAwardList.ShowDialog();
                    break;
                 case "103": //中奖者名单
                        if (MessageBox.Show("确定要退出吗?", "退出确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            System.Environment.Exit(0);
                        }
                    break;
            }           
        }
        private void DropLab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗?", "退出确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
