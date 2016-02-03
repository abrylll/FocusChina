using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
//Access读取
using System.Data.OleDb;

namespace Lottery
{
    public partial class FrmAwardList : Form
    {
        private string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\database\\SeedData.mdb;";

        public FrmAwardList()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//界面初始化
        private void FrmSetup_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\AwardShow.jpg");
            Btn_Review.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_review.png");
            Btn_Back.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_back.png");
            Btn_Export.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\images\\btn_export.png");
            Btn_Review_Click(null, null);
        }
//刷新
        private void Btn_Review_Click(object sender, EventArgs e)
        {
            SeedList.Items.Clear();
             string strConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\database\\SeedData.mdb;";
                OleDbConnection odcConnection = new OleDbConnection(strConn);
                odcConnection.Open();
                OleDbCommand odCommand = odcConnection.CreateCommand();
                odCommand.CommandText = "select id,award,employee_dept,employee_name,employee_no from Awardlist order by id asc";
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
                  odCommand.CommandText = "select count(*) as result from Awardlist ";
                  OleDbDataReader odrCount = odCommand.ExecuteReader();
                  odrCount.Read();
                  LabInfo.Text = "中奖人员共 " + odrCount[0].ToString() + " 人";
                  odrCount.Close();
                  odcConnection.Close();
        }       
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Export_Click(object sender, EventArgs e)
        {
            OleDbConnection odcConnection = new OleDbConnection(strConn);
            odcConnection.Open();
            OleDbCommand odCommand = odcConnection.CreateCommand();
            odCommand.CommandText = "select id,award,employee_dept,employee_name,employee_no from Awardlist order by pubdate asc";
            OleDbDataReader odrReader = odCommand.ExecuteReader();
            string ExportTxt = "中奖奖项\t所属部门\t姓名\t 工号\r\n";
            while (odrReader.Read())
            {
                ExportTxt += odrReader[1].ToString() + "\t" + odrReader[2].ToString() + "\t" + odrReader[3].ToString() + "\t" + odrReader[4].ToString() + "\r\n";                
            }
            odrReader.Close();
            odcConnection.Close();
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            //选择的路径
            string RootPath;
            RootPath = folderBrowserDialog.SelectedPath;
            if (RootPath.Length > 0)
            {
                //保存文件
                DateTime dt = DateTime.Now;
                string Save_file = RootPath + "\\中奖结果" + dt.ToString("yyyyMMddHHmmss") + ".txt";
                //创建一个文件流，用以写入或者创建一个StreamWriter
                FileStream fs = new FileStream(Save_file, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs);
                m_streamWriter.Flush();
                //  使用StreamWriter来往文件中写入内容
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                m_streamWriter.Write(ExportTxt);
                //关闭此文件
                m_streamWriter.Flush();
                m_streamWriter.Close();
                MessageBox.Show("中奖已保存到  " + Save_file);
            }
        }
    }
}
