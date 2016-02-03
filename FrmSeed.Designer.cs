namespace Lottery
{
    partial class FrmSeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeed));
            this.BtnExit = new System.Windows.Forms.Label();
            this.SeedList = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_dept = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employee_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.award_flag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Review = new System.Windows.Forms.PictureBox();
            this.Btn_Back = new System.Windows.Forms.PictureBox();
            this.LabInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Review)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.Location = new System.Drawing.Point(2, 1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(70, 61);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // SeedList
            // 
            this.SeedList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.employee_dept,
            this.employee_name,
            this.employee_no,
            this.award_flag});
            this.SeedList.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SeedList.Location = new System.Drawing.Point(330, 205);
            this.SeedList.MultiSelect = false;
            this.SeedList.Name = "SeedList";
            this.SeedList.Size = new System.Drawing.Size(1230, 716);
            this.SeedList.TabIndex = 12;
            this.SeedList.UseCompatibleStateImageBehavior = false;
            this.SeedList.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "唯一ID";
            this.id.Width = 82;
            // 
            // employee_dept
            // 
            this.employee_dept.Text = "所属部门";
            this.employee_dept.Width = 617;
            // 
            // employee_name
            // 
            this.employee_name.Text = "员工姓名";
            this.employee_name.Width = 175;
            // 
            // employee_no
            // 
            this.employee_no.Text = "员工工号";
            this.employee_no.Width = 184;
            // 
            // award_flag
            // 
            this.award_flag.Text = "是否中奖";
            this.award_flag.Width = 129;
            // 
            // Btn_Review
            // 
            this.Btn_Review.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Review.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Review.Location = new System.Drawing.Point(699, 956);
            this.Btn_Review.Name = "Btn_Review";
            this.Btn_Review.Size = new System.Drawing.Size(202, 66);
            this.Btn_Review.TabIndex = 15;
            this.Btn_Review.TabStop = false;
            this.Btn_Review.Click += new System.EventHandler(this.Btn_Review_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.Location = new System.Drawing.Point(963, 956);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(202, 66);
            this.Btn_Back.TabIndex = 16;
            this.Btn_Back.TabStop = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // LabInfo
            // 
            this.LabInfo.BackColor = System.Drawing.Color.Transparent;
            this.LabInfo.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabInfo.ForeColor = System.Drawing.Color.White;
            this.LabInfo.Location = new System.Drawing.Point(334, 924);
            this.LabInfo.Name = "LabInfo";
            this.LabInfo.Size = new System.Drawing.Size(704, 29);
            this.LabInfo.TabIndex = 17;
            // 
            // FrmSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.LabInfo);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Review);
            this.Controls.Add(this.SeedList);
            this.Controls.Add(this.BtnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.FrmSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Review)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BtnExit;
        private System.Windows.Forms.ListView SeedList;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader employee_dept;
        private System.Windows.Forms.ColumnHeader employee_name;
        private System.Windows.Forms.ColumnHeader employee_no;
        private System.Windows.Forms.PictureBox Btn_Review;
        private System.Windows.Forms.PictureBox Btn_Back;
        private System.Windows.Forms.Label LabInfo;
        private System.Windows.Forms.ColumnHeader award_flag;
    }
}