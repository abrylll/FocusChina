namespace Lottery
{
    partial class FrmAwardLucky5
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwardLucky5));
            this.BtnStart = new System.Windows.Forms.PictureBox();
            this.LabCorp1 = new System.Windows.Forms.Label();
            this.LabName1 = new System.Windows.Forms.Label();
            this.timer_lottery = new System.Windows.Forms.Timer(this.components);
            this.labelExit = new System.Windows.Forms.Label();
            this.SeedsList = new System.Windows.Forms.ListBox();
            this.LabName2 = new System.Windows.Forms.Label();
            this.LabCorp2 = new System.Windows.Forms.Label();
            this.LabName4 = new System.Windows.Forms.Label();
            this.LabCorp4 = new System.Windows.Forms.Label();
            this.LabName3 = new System.Windows.Forms.Label();
            this.LabCorp3 = new System.Windows.Forms.Label();
            this.LabName5 = new System.Windows.Forms.Label();
            this.LabCorp5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.BackgroundImage")));
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.ErrorImage")));
            this.BtnStart.Location = new System.Drawing.Point(857, 946);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(202, 66);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.TabStop = false;
            this.BtnStart.Click += new System.EventHandler(this.picture_Click);
            // 
            // LabCorp1
            // 
            this.LabCorp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp1.Font = new System.Drawing.Font("微软雅黑", 28F);
            this.LabCorp1.ForeColor = System.Drawing.Color.White;
            this.LabCorp1.Location = new System.Drawing.Point(224, 284);
            this.LabCorp1.Name = "LabCorp1";
            this.LabCorp1.Size = new System.Drawing.Size(900, 100);
            this.LabCorp1.TabIndex = 2;
            this.LabCorp1.Text = " ";
            this.LabCorp1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName1
            // 
            this.LabName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.LabName1.ForeColor = System.Drawing.Color.White;
            this.LabName1.Location = new System.Drawing.Point(1155, 282);
            this.LabName1.Name = "LabName1";
            this.LabName1.Size = new System.Drawing.Size(540, 100);
            this.LabName1.TabIndex = 3;
            this.LabName1.Text = " ";
            this.LabName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_lottery
            // 
            this.timer_lottery.Interval = 5;
            this.timer_lottery.Tick += new System.EventHandler(this.timer_lottery_Tick);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Location = new System.Drawing.Point(1, 2);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(70, 61);
            this.labelExit.TabIndex = 4;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // SeedsList
            // 
            this.SeedsList.FormattingEnabled = true;
            this.SeedsList.ItemHeight = 12;
            this.SeedsList.Location = new System.Drawing.Point(3, 968);
            this.SeedsList.Name = "SeedsList";
            this.SeedsList.Size = new System.Drawing.Size(292, 100);
            this.SeedsList.TabIndex = 5;
            this.SeedsList.Visible = false;
            // 
            // LabName2
            // 
            this.LabName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.LabName2.ForeColor = System.Drawing.Color.White;
            this.LabName2.Location = new System.Drawing.Point(1155, 404);
            this.LabName2.Name = "LabName2";
            this.LabName2.Size = new System.Drawing.Size(540, 100);
            this.LabName2.TabIndex = 7;
            this.LabName2.Text = " ";
            this.LabName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCorp2
            // 
            this.LabCorp2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp2.Font = new System.Drawing.Font("微软雅黑", 28F);
            this.LabCorp2.ForeColor = System.Drawing.Color.White;
            this.LabCorp2.Location = new System.Drawing.Point(224, 404);
            this.LabCorp2.Name = "LabCorp2";
            this.LabCorp2.Size = new System.Drawing.Size(900, 100);
            this.LabCorp2.TabIndex = 6;
            this.LabCorp2.Text = " ";
            this.LabCorp2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName4
            // 
            this.LabName4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName4.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.LabName4.ForeColor = System.Drawing.Color.White;
            this.LabName4.Location = new System.Drawing.Point(1155, 644);
            this.LabName4.Name = "LabName4";
            this.LabName4.Size = new System.Drawing.Size(540, 100);
            this.LabName4.TabIndex = 11;
            this.LabName4.Text = " ";
            this.LabName4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCorp4
            // 
            this.LabCorp4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp4.Font = new System.Drawing.Font("微软雅黑", 28F);
            this.LabCorp4.ForeColor = System.Drawing.Color.White;
            this.LabCorp4.Location = new System.Drawing.Point(224, 644);
            this.LabCorp4.Name = "LabCorp4";
            this.LabCorp4.Size = new System.Drawing.Size(900, 100);
            this.LabCorp4.TabIndex = 10;
            this.LabCorp4.Text = " ";
            this.LabCorp4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName3
            // 
            this.LabName3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName3.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.LabName3.ForeColor = System.Drawing.Color.White;
            this.LabName3.Location = new System.Drawing.Point(1155, 524);
            this.LabName3.Name = "LabName3";
            this.LabName3.Size = new System.Drawing.Size(540, 100);
            this.LabName3.TabIndex = 9;
            this.LabName3.Text = " ";
            this.LabName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCorp3
            // 
            this.LabCorp3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp3.Font = new System.Drawing.Font("微软雅黑", 28F);
            this.LabCorp3.ForeColor = System.Drawing.Color.White;
            this.LabCorp3.Location = new System.Drawing.Point(224, 524);
            this.LabCorp3.Name = "LabCorp3";
            this.LabCorp3.Size = new System.Drawing.Size(900, 100);
            this.LabCorp3.TabIndex = 8;
            this.LabCorp3.Text = " ";
            this.LabCorp3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabName5
            // 
            this.LabName5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName5.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold);
            this.LabName5.ForeColor = System.Drawing.Color.White;
            this.LabName5.Location = new System.Drawing.Point(1155, 764);
            this.LabName5.Name = "LabName5";
            this.LabName5.Size = new System.Drawing.Size(540, 100);
            this.LabName5.TabIndex = 13;
            this.LabName5.Text = " ";
            this.LabName5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabCorp5
            // 
            this.LabCorp5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp5.Font = new System.Drawing.Font("微软雅黑", 28F);
            this.LabCorp5.ForeColor = System.Drawing.Color.White;
            this.LabCorp5.Location = new System.Drawing.Point(224, 764);
            this.LabCorp5.Name = "LabCorp5";
            this.LabCorp5.Size = new System.Drawing.Size(900, 100);
            this.LabCorp5.TabIndex = 12;
            this.LabCorp5.Text = " ";
            this.LabCorp5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAwardLucky5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.LabName5);
            this.Controls.Add(this.LabCorp5);
            this.Controls.Add(this.LabName4);
            this.Controls.Add(this.LabCorp4);
            this.Controls.Add(this.LabName3);
            this.Controls.Add(this.LabCorp3);
            this.Controls.Add(this.LabName2);
            this.Controls.Add(this.LabCorp2);
            this.Controls.Add(this.SeedsList);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.LabName1);
            this.Controls.Add(this.LabCorp1);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAwardLucky5";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖程序";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmKey_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnStart;
        private System.Windows.Forms.Label LabCorp1;
        private System.Windows.Forms.Label LabName1;
        private System.Windows.Forms.Timer timer_lottery;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ListBox SeedsList;
        private System.Windows.Forms.Label LabName2;
        private System.Windows.Forms.Label LabCorp2;
        private System.Windows.Forms.Label LabName4;
        private System.Windows.Forms.Label LabCorp4;
        private System.Windows.Forms.Label LabName3;
        private System.Windows.Forms.Label LabCorp3;
        private System.Windows.Forms.Label LabName5;
        private System.Windows.Forms.Label LabCorp5;
    }
}

