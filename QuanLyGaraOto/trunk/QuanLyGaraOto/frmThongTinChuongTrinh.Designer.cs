namespace QuanLyGaraOto
{
    partial class frmThongTinChuongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinChuongTrinh));
            this.picBoxIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.txtPhienBan = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxIcon
            // 
            this.picBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.Image")));
            this.picBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxIcon.InitialImage")));
            this.picBoxIcon.Location = new System.Drawing.Point(265, 9);
            this.picBoxIcon.Name = "picBoxIcon";
            this.picBoxIcon.Size = new System.Drawing.Size(65, 67);
            this.picBoxIcon.TabIndex = 0;
            this.picBoxIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên chương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phiên bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghi chú";
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(106, 6);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.ReadOnly = true;
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(100, 20);
            this.txtTenChuongTrinh.TabIndex = 4;
            this.txtTenChuongTrinh.Text = "Quản lý gara ôtô";
            // 
            // txtPhienBan
            // 
            this.txtPhienBan.Location = new System.Drawing.Point(106, 45);
            this.txtPhienBan.Name = "txtPhienBan";
            this.txtPhienBan.ReadOnly = true;
            this.txtPhienBan.Size = new System.Drawing.Size(100, 20);
            this.txtPhienBan.TabIndex = 5;
            this.txtPhienBan.Text = "1.0";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(106, 92);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(224, 93);
            this.txtGhiChu.TabIndex = 6;
            this.txtGhiChu.Text = "Đồ án môn học Nhập môn công nghệ phần mềm\r\nThực hiện:\r\n- 09520319 - Võ Minh Trí\r\n" +
    "- 09520326 - Trịnh Hồng Trường\r\n";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(106, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongTinChuongTrinh
            // 
            this.ClientSize = new System.Drawing.Size(362, 247);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtPhienBan);
            this.Controls.Add(this.txtTenChuongTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxIcon);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(378, 285);
            this.MinimumSize = new System.Drawing.Size(378, 285);
            this.Name = "frmThongTinChuongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chương trình";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.TextBox txtPhienBan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}