namespace Lottery
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.AwardSel = new System.Windows.Forms.ListBox();
            this.BtnIn = new System.Windows.Forms.PictureBox();
            this.DropLab = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnIn)).BeginInit();
            this.SuspendLayout();
            // 
            // AwardSel
            // 
            this.AwardSel.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.AwardSel.FormattingEnabled = true;
            this.AwardSel.ItemHeight = 31;
            this.AwardSel.Location = new System.Drawing.Point(456, 252);
            this.AwardSel.Name = "AwardSel";
            this.AwardSel.Size = new System.Drawing.Size(1072, 562);
            this.AwardSel.TabIndex = 2;
            // 
            // BtnIn
            // 
            this.BtnIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIn.BackgroundImage")));
            this.BtnIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnIn.ErrorImage")));
            this.BtnIn.Location = new System.Drawing.Point(897, 833);
            this.BtnIn.Name = "BtnIn";
            this.BtnIn.Size = new System.Drawing.Size(202, 66);
            this.BtnIn.TabIndex = 3;
            this.BtnIn.TabStop = false;
            this.BtnIn.Click += new System.EventHandler(this.BtnIn_Click);
            // 
            // DropLab
            // 
            this.DropLab.BackColor = System.Drawing.Color.Transparent;
            this.DropLab.Location = new System.Drawing.Point(1552, 2);
            this.DropLab.Name = "DropLab";
            this.DropLab.Size = new System.Drawing.Size(365, 113);
            this.DropLab.TabIndex = 6;
            this.DropLab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DropLab_MouseDown);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Location = new System.Drawing.Point(2, 2);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(70, 61);
            this.labelExit.TabIndex = 7;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.DropLab);
            this.Controls.Add(this.BtnIn);
            this.Controls.Add(this.AwardSel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "企业年会抽奖系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox SeedsList;
        private System.Windows.Forms.ListBox AwardSel;
        private System.Windows.Forms.PictureBox BtnIn;
        private System.Windows.Forms.Label DropLab;
        private System.Windows.Forms.Label labelExit;
    }
}