namespace QuanLyGaraOto.formCSDL
{
    partial class frmVatTuPhuTung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatTuPhuTung));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTim = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvTim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaVTPT = new System.Windows.Forms.TextBox();
            this.txtTenVTPT = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDen = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // cbbTim
            // 
            this.cbbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTim.FormattingEnabled = true;
            this.cbbTim.Items.AddRange(new object[] {
            "Mã VTPT",
            "Tên VTPT",
            "Đơn giá nhập",
            "Đơn giá bán",
            "Số lượng tồn"});
            this.cbbTim.Location = new System.Drawing.Point(75, 6);
            this.cbbTim.Name = "cbbTim";
            this.cbbTim.Size = new System.Drawing.Size(108, 21);
            this.cbbTim.TabIndex = 1;
            this.cbbTim.SelectedIndexChanged += new System.EventHandler(this.cbbTim_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(189, 7);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(355, 20);
            this.txtTim.TabIndex = 2;
            // 
            // dgvTim
            // 
            this.dgvTim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTim.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTim.Location = new System.Drawing.Point(24, 33);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.Size = new System.Drawing.Size(520, 174);
            this.dgvTim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã vật tư phụ tùng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên vật tư phụ tùng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá bán";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn giá nhập";
            // 
            // txtMaVTPT
            // 
            this.txtMaVTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaVTPT.Location = new System.Drawing.Point(138, 221);
            this.txtMaVTPT.Name = "txtMaVTPT";
            this.txtMaVTPT.Size = new System.Drawing.Size(100, 20);
            this.txtMaVTPT.TabIndex = 9;
            // 
            // txtTenVTPT
            // 
            this.txtTenVTPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenVTPT.Location = new System.Drawing.Point(351, 221);
            this.txtTenVTPT.Name = "txtTenVTPT";
            this.txtTenVTPT.Size = new System.Drawing.Size(100, 20);
            this.txtTenVTPT.TabIndex = 10;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(138, 245);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongTon.TabIndex = 11;
            this.txtSoLuongTon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongTon_KeyPress);
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDonGiaNhap.Location = new System.Drawing.Point(351, 245);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtDonGiaNhap.TabIndex = 12;
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(138, 271);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtDonGiaBan.TabIndex = 13;
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "VNĐ";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(138, 306);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(247, 306);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(193, 10);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 18;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(318, 9);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 19;
            this.lbDen.Text = "Đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(219, 7);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(81, 20);
            this.txtTu.TabIndex = 20;
            this.txtTu.TextChanged += new System.EventHandler(this.txtTu_TextChanged);
            this.txtTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTu_KeyPress);
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(351, 7);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(81, 20);
            this.txtDen.TabIndex = 21;
            this.txtDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDen_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(448, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 22;
            this.btnTim.Text = "Tìm";
            // 
            // frmVatTuPhuTung
            // 
            this.ClientSize = new System.Drawing.Size(585, 335);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.txtTenVTPT);
            this.Controls.Add(this.txtMaVTPT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbbTim);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(601, 373);
            this.Name = "frmVatTuPhuTung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vật tư phụ tùng";
            this.Load += new System.EventHandler(this.frmVatTuPhuTung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTim;
        private System.Windows.Forms.TextBox txtTim;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaVTPT;
        private System.Windows.Forms.TextBox txtTenVTPT;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private DevComponents.DotNetBar.ButtonX btnTim;
    }
}