using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//Access读取
using System.Data.OleDb;

namespace Lottery
{
    public partial class FrmSetup : Form
    {
        private string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\database\\SeedData.mdb;";

        public FrmSetup()
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
            this.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\SetupBG.jpg");
            Btn_Import.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_import.png");
            Btn_Clear.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_clear.png");
            Btn_Review.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_review.png");
            Btn_Back.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_back.png");
            Btn_Review_Click(null, null);
        }
//清空列表和数据表
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清空列表?清空将删除所有数据,包括中奖记录", "清空确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SeedList.Items.Clear();
                OleDbConnection odcConnection = new OleDbConnection(strConn);
                odcConnection.Open();
                OleDbCommand odCommand = odcConnection.CreateCommand();
                odCommand.CommandText = "delete from seedlist";
                odCommand.ExecuteNonQuery();
                odCommand.CommandText = "delete from awardlist";
                odCommand.ExecuteNonQuery();
                odcConnection.Close();
                LabInfo.Text = "待抽奖人员数据库已清空";
            }
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
        private void Btn_Import_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("导入数据将删除系统内所有数据,包括中奖记录，确认要导入并建立一次新的抽奖活动吗？", "清空确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int allcount = 0;
                OpenFileDialog opf = new OpenFileDialog();
                opf.Title = "请选择TXT格式的人员信息列表";
                opf.Filter = "TXT文件(*.txt)|*.txt";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    SeedList.Items.Clear();
                    OleDbConnection odcConnection = new OleDbConnection(strConn);
                    odcConnection.Open();
                    OleDbCommand odCommand = odcConnection.CreateCommand();
                    odCommand.CommandText = "delete from seedlist";
                    odCommand.ExecuteNonQuery();
                    odCommand.CommandText = "delete from awardlist";
                    odCommand.ExecuteNonQuery();

                    FileStream fs = new FileStream(opf.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader m_streamReader = new StreamReader(fs);
                    m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    string strLine = m_streamReader.ReadLine();
                    while (strLine != null)
                    {
                        char[] delimiterChars = { ';' };
                        string[] sArray = strLine.Split(delimiterChars);
                        if (sArray.GetLength(0) == 3)  //如果读出一行切割后,数
                        {
                            allcount++;
                            AccessInfo AccessInfo;
                            AccessInfo.id = allcount;
                            AccessInfo.employee_dept = sArray[0];
                            AccessInfo.employee_name = sArray[1];
                            AccessInfo.employee_no = sArray[2];                                                      

                            ListViewItem li = new ListViewItem();
                            li.SubItems.Clear();
                            li.SubItems[0].Text = AccessInfo.id.ToString();
                            li.SubItems.Add(AccessInfo.employee_dept);
                            li.SubItems.Add(AccessInfo.employee_name);
                            li.SubItems.Add(AccessInfo.employee_no);
                            
                            SeedList.Items.Add(li);
                            odCommand.CommandText = "insert into seedlist(id,employee_dept,employee_name,employee_no) values('" + AccessInfo.id.ToString() + "','" + AccessInfo.employee_dept + "','" + AccessInfo.employee_name + "','" + AccessInfo.employee_no + "')";
                            odCommand.ExecuteNonQuery();
                        }
                        strLine = m_streamReader.ReadLine(); //读下一行
                    }
                    m_streamReader.Close();
                    odCommand.CommandText = "select count(*) as result from seedlist";
                    OleDbDataReader odrCount = odCommand.ExecuteReader();
                    odrCount.Read();
                    LabInfo.Text = "当前系统中共有待抽奖人员 " + odrCount[0].ToString() + " 人";
                    odrCount.Close();
                    odcConnection.Close();

                }
                //if (allcount > 0) MessageBox.Show("添加抽奖人员名单完成,一共导入了 " + allcount + " 条人员信息");
            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
