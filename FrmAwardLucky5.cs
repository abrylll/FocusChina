﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//Access读取
using System.Data.OleDb;

namespace Lottery
{
    public partial class FrmAwardLucky5 : Form
    {
        private Label[] LabCorp;
        private Label[] LabName;
        private string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\database\\SeedData.mdb;";
        private string AwardName; 
        private string BGimage;  

        //奖项名称地址
        public string ShowAward
        {
            get { return AwardName; }
            set { AwardName = value; }
        }

        //背景图地址
        public string PhotoBGImage
        {
            get { return BGimage; }
            set { BGimage = value; }
        }


        public FrmAwardLucky5()
        {
            InitializeComponent();
            LabCorp = new Label[20];
            LabCorp[0] = LabCorp1;
            LabCorp[1] = LabCorp2;
            LabCorp[2] = LabCorp3;
            LabCorp[3] = LabCorp4;
            LabCorp[4] = LabCorp5;


            LabName = new Label[20];
            LabName[0] = LabName1;
            LabName[1] = LabName2;
            LabName[2] = LabName3;
            LabName[3] = LabName4;
            LabName[4] = LabName5;
        
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            string strPath = System.IO.Directory.GetCurrentDirectory() + BGimage;
            this.BackgroundImage = Image.FromFile(strPath);
            BtnStart.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_start.png");
            //从数据库里读出所有可抽奖人员
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            odcConnection.Open();
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = "select count(*) as result from seedlist";
            OleDbDataReader odrCount = odCommand.ExecuteReader();
            odrCount.Read();
            int allcount = Int32.Parse(odrCount[0].ToString());
            odrCount.Close();
            if (allcount < 9)
            {
                odcConnection.Close();
                MessageBox.Show("可供抽奖的人数不足,无法抽奖");
                this.Close();
            }
            else
            {
                //读取所有记录到数据
                SeedsList.Items.Clear();
                odCommand.CommandText = "select id,employee_dept,employee_name,employee_no from Seedlist where award_flag = '0' order by id asc";
                OleDbDataReader odrReader = odCommand.ExecuteReader();
                while (odrReader.Read())
                {
                    SeedsList.Items.Add(odrReader[0].ToString() + ";" + odrReader[1].ToString() + ";" + odrReader[2].ToString() + ";" + odrReader[3].ToString());
                }
                odrReader.Close();
                odcConnection.Close();
            }           
        }
//点击开始/停止滚动
        private void picture_Click(object sender, EventArgs e)
        {
            lottyCtrl();
        } 
        private void lottyCtrl()
        {
            //开始
            string strPath = "";
            int ocont = 0;
            ocont = SeedsList.Items.Count - 1;
            //随机数
            if (timer_lottery.Enabled == false)
            {
                if (ocont > 5)
                {
                    timer_lottery.Enabled = true;
                    strPath = System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_end.png";
                    BtnStart.Image = Image.FromFile(strPath);
                }
                else
                {
                    MessageBox.Show("已没有可供抽取的人员，抽奖中止");
                }
            }
            else
            {
                strPath = System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_start.png";
                BtnStart.Image = Image.FromFile(strPath);
                timer_lottery.Enabled = false;

                //从数据库中抽一个人，显示，记录
                OleDbConnection odcConnection = new OleDbConnection(strConn);
                odcConnection.Open();
                OleDbCommand odCommand = odcConnection.CreateCommand();
                DateTime dt = DateTime.Now;
                char[] delimiterChars = { ';' };
                byte[] bytes = new byte[4];
                for (int i = 0; i < 5; i++)  //抽八个奖
                {
                    Application.DoEvents(); 
                    System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                    rng.GetBytes(bytes);
                    Random rnd2 = new Random(BitConverter.ToInt32(bytes, 0));
                    int rndNum = rnd2.Next(0, SeedsList.Items.Count - 1);
                    string Rtext = SeedsList.Items[rndNum].ToString();
                    string[] sArray = Rtext.Split(delimiterChars);
                    LabName[i].Text = sArray[2] + "[" + sArray[3] + "]";
                    LabCorp[i].Text = sArray[1];
                    string inaward = sArray[0].ToString();
                    string inaward_sql = "INSERT INTO AwardList(award,employee_dept,employee_name,employee_no,pubdate) VALUES('" + AwardName + "','" + sArray[1].ToString() + "','" + sArray[2].ToString() + "','" + sArray[3].ToString() + "','" + dt.ToString("yyyyMMddHHmmss") + "')";
                    odCommand.CommandText = "update seedlist set award_flag = '1'  where id = " + inaward;
                    odCommand.ExecuteNonQuery();
                    odCommand.CommandText = inaward_sql;
                    odCommand.ExecuteNonQuery();
                    SeedsList.Items.Clear();
                    odCommand.CommandText = "select id,employee_dept,employee_name,employee_no from Seedlist where award_flag = '0' order by id asc";
                    OleDbDataReader odrReader = odCommand.ExecuteReader();
                    while (odrReader.Read())
                    {
                        SeedsList.Items.Add(odrReader[0].ToString() + ";" + odrReader[1].ToString() + ";" + odrReader[2].ToString() + ";" + odrReader[3].ToString());
                    }
                    odrReader.Close();
                }
                odcConnection.Close();
            }
        }        
        //随机取一行，取一个从列表里删一个
        private string rndshow()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            Random rnd2 = new Random(BitConverter.ToInt32(bytes, 0));
            int rndNum = rnd2.Next(0, SeedsList.Items.Count - 1);
            string Rtext = SeedsList.Items[rndNum].ToString();
            return Rtext;
        }
//滚动
        private void timer_lottery_Tick(object sender, EventArgs e)
        {
            string Rtext = "";
            char[] delimiterChars = { ';' };
            for (int i = 0; i < 5; i++)
            {
                Rtext = rndshow();
                string[] sArray = Rtext.Split(delimiterChars);
                LabName[i].Text = sArray[2] + "[" + sArray[3] + "]";
                LabCorp[i].Text = sArray[1];
            }
        }
        private void FrmKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) 
            {
                lottyCtrl();
            }
        }
//退出处理
        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
