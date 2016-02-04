using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

//Access读取
using System.Data.OleDb;

namespace Lottery
{
    public partial class FrmSeed : Form
    {
        private string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\database\\SeedData.mdb;";
        public FrmSeed()
        {
            InitializeComponent();
        }

        //读取Access的结构类型
        struct AccessInfo
        {
            public int id;                                       //id号
            public string employee_dept;            //所属部门
            public string employee_name;          //姓名
            public string employee_no;              //工号                      
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//界面初始化
        private void FrmSetup_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\Seed.jpg");
            Btn_Review.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_review.png");
            Btn_Back.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_back.png");
            Btn_Review_Click(null, null);
        }
//刷新
        private void Btn_Review_Click(object sender, EventArgs e)
        {
            SeedList.Items.Clear();
            OleDbConnection odcConnection = new OleDbConnection(strConn);
                odcConnection.Open();
                OleDbCommand odCommand = odcConnection.CreateCommand();
                odCommand.CommandText = "select id,employee_dept,employee_name,employee_no,award_flag from Seedlist order by id asc";
                  OleDbDataReader odrReader = odCommand.ExecuteReader();
                  while (odrReader.Read())
                  {
                      ListViewItem li = new ListViewItem();
                      li.SubItems.Clear();
                      li.SubItems[0].Text = odrReader[0].ToString();
                      li.SubItems.Add(odrReader[1].ToString());
                      li.SubItems.Add(odrReader[2].ToString());
                      li.SubItems.Add(odrReader[3].ToString());
                      li.SubItems.Add(odrReader[4].ToString());
                      SeedList.Items.Add(li);
                  }
                  odrReader.Close();

                  odCommand.CommandText = "select count(*) as result from seedlist";
                  OleDbDataReader odrCount = odCommand.ExecuteReader();
                  odrCount.Read();
                  LabInfo.Text = "当前系统中共有待抽奖人员 " + odrCount[0].ToString() + " 人";
                  odrCount.Close();

                  odCommand.CommandText = "select count(*) as result from seedlist where award_flag = '1'";
                  odrCount = odCommand.ExecuteReader();
                  odrCount.Read();

                  LabInfo.Text += "，其中已中奖人员 " + odrCount[0].ToString() + " 人";
                  odrCount.Close();
                  odcConnection.Close();
        }       
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
