namespace QuanLyGaraOto.formHeThong
{
    partial class frmCauHinhLaiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCauHinhLaiCSDL));
            this.columnHeader1 = new DevComponents.AdvTree.ColumnHeader();
            this.cbCSDL = new System.Windows.Forms.ComboBox();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.columnHeader2 = new DevComponents.AdvTree.ColumnHeader();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btnHuyBo = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.btnKiemTraKetNoi = new DevComponents.DotNetBar.ButtonX();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Xác thực bằng Windows";
            this.columnHeader1.Width.Absolute = 150;
            // 
            // cbCSDL
            // 
            this.cbCSDL.FormattingEnabled = true;
            this.cbCSDL.Location = new System.Drawing.Point(95, 84);
            this.cbCSDL.Name = "cbCSDL";
            this.cbCSDL.Size = new System.Drawing.Size(186, 21);
            this.cbCSDL.TabIndex = 29;
            // 
            // cbbServer
            // 
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(95, 13);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(186, 21);
            this.cbbServer.TabIndex = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Xác thực bằng Server";
            this.columnHeader2.Width.Absolute = 150;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Xác thực bằng Windows",
            "Xác thực bằng Server"});
            this.cbbQuyen.Location = new System.Drawing.Point(95, 51);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(186, 21);
            this.cbbQuyen.TabIndex = 27;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyBo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyBo.Location = new System.Drawing.Point(155, 197);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(124, 23);
            this.btnHuyBo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuyBo.TabIndex = 26;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnLuuKetNoi
            // 
            this.btnLuuKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuKetNoi.Location = new System.Drawing.Point(25, 197);
            this.btnLuuKetNoi.Name = "btnLuuKetNoi";
            this.btnLuuKetNoi.Size = new System.Drawing.Size(124, 23);
            this.btnLuuKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuuKetNoi.TabIndex = 25;
            this.btnLuuKetNoi.Text = "Lưu kết nối";
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKiemTraKetNoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(95, 168);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(124, 23);
            this.btnKiemTraKetNoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKiemTraKetNoi.TabIndex = 24;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMatKhau.Location = new System.Drawing.Point(95, 142);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(186, 20);
            this.txtMatKhau.TabIndex = 23;
            // 
            // txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTenTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTenTaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(95, 116);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(186, 20);
            this.txtTenTaiKhoan.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cơ sở dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Xác thực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Server:";
            // 
            // frmCauHinhLaiCSDL
            // 
            this.ClientSize = new System.Drawing.Size(287, 248);
            this.ControlBox = false;
            this.Controls.Add(this.cbCSDL);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.cbbQuyen);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuuKetNoi);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(303, 286);
            this.MinimumSize = new System.Drawing.Size(303, 286);
            this.Name = "frmCauHinhLaiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình cơ sở dữ liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.AdvTree.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbCSDL;
        private System.Windows.Forms.ComboBox cbbServer;
        private DevComponents.AdvTree.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private DevComponents.DotNetBar.ButtonX btnHuyBo;
        private DevComponents.DotNetBar.ButtonX btnLuuKetNoi;
        private DevComponents.DotNetBar.ButtonX btnKiemTraKetNoi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTaiKhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}