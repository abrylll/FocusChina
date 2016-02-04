namespace Lottery
{
    partial class FrmAwardLucky1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwardLucky1));
            this.BtnStart = new System.Windows.Forms.PictureBox();
            this.LabCorp = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.timer_lottery = new System.Windows.Forms.Timer(this.components);
            this.labelExit = new System.Windows.Forms.Label();
            this.SeedsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Transparent;
            this.BtnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.BackgroundImage")));
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnStart.ErrorImage")));
            this.BtnStart.Location = new System.Drawing.Point(872, 968);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(202, 66);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.TabStop = false;
            this.BtnStart.Click += new System.EventHandler(this.picture_Click);
            // 
            // LabCorp
            // 
            this.LabCorp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabCorp.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabCorp.ForeColor = System.Drawing.Color.White;
            this.LabCorp.Location = new System.Drawing.Point(306, 314);
            this.LabCorp.Name = "LabCorp";
            this.LabCorp.Size = new System.Drawing.Size(1307, 193);
            this.LabCorp.TabIndex = 2;
            this.LabCorp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabName
            // 
            this.LabName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(31)))), ((int)(((byte)(61)))));
            this.LabName.Font = new System.Drawing.Font("微软雅黑", 80F, System.Drawing.FontStyle.Bold);
            this.LabName.ForeColor = System.Drawing.Color.White;
            this.LabName.Location = new System.Drawing.Point(305, 565);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(1308, 186);
            this.LabName.TabIndex = 3;
            this.LabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_lottery
            // 
            this.timer_lottery.Interval = 20;
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
            this.SeedsList.Location = new System.Drawing.Point(3, 945);
            this.SeedsList.Name = "SeedsList";
            this.SeedsList.Size = new System.Drawing.Size(277, 124);
            this.SeedsList.TabIndex = 5;
            this.SeedsList.Visible = false;
            // 
            // FrmAwardLucky1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.SeedsList);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.LabCorp);
            this.Controls.Add(this.BtnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAwardLucky1";
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
        private System.Windows.Forms.Label LabCorp;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Timer timer_lottery;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.ListBox SeedsList;
    }
}

