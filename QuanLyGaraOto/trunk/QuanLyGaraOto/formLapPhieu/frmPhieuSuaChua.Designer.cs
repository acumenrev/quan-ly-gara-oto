namespace QuanLyGaraOto.formLapPhieu
{
    partial class frmPhieuSuaChua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuSuaChua));
            this.txtTimTTChung = new System.Windows.Forms.TextBox();
            this.cbbTimTTChung = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTimTTChung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaTTChung = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTTChung = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTTChung = new DevComponents.DotNetBar.ButtonX();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgaySuaChua = new System.Windows.Forms.DateTimePicker();
            this.cbbBienSoXe = new System.Windows.Forms.ComboBox();
            this.txtMaPSC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbMaVTPT = new System.Windows.Forms.ComboBox();
            this.cbbNoiDung = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvTimTTRieng = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTimTTRieng = new System.Windows.Forms.TextBox();
            this.cbbTimTTRieng = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.txtTimDenSoTien = new System.Windows.Forms.TextBox();
            this.txtTimTuSoTien = new System.Windows.Forms.TextBox();
            this.lbTu = new System.Windows.Forms.Label();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTTChung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTTRieng)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimTTChung
            // 
            this.txtTimTTChung.Location = new System.Drawing.Point(182, 10);
            this.txtTimTTChung.Name = "txtTimTTChung";
            this.txtTimTTChung.Size = new System.Drawing.Size(467, 20);
            this.txtTimTTChung.TabIndex = 6;
            // 
            // cbbTimTTChung
            // 
            this.cbbTimTTChung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTTChung.FormattingEnabled = true;
            this.cbbTimTTChung.Items.AddRange(new object[] {
            "Mã phiếu sửa chữa",
            "Biến số xe",
            "Ngày sửa xe",
            "Tổng tiền"});
            this.cbbTimTTChung.Location = new System.Drawing.Point(55, 9);
            this.cbbTimTTChung.Name = "cbbTimTTChung";
            this.cbbTimTTChung.Size = new System.Drawing.Size(121, 21);
            this.cbbTimTTChung.TabIndex = 5;
            this.cbbTimTTChung.SelectedIndexChanged += new System.EventHandler(this.cbbTimTTChung_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm theo";
            // 
            // dgvTimTTChung
            // 
            this.dgvTimTTChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimTTChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimTTChung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimTTChung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTimTTChung.Location = new System.Drawing.Point(4, 36);
            this.dgvTimTTChung.Name = "dgvTimTTChung";
            this.dgvTimTTChung.Size = new System.Drawing.Size(645, 136);
            this.dgvTimTTChung.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaTTChung);
            this.groupBox1.Controls.Add(this.btnSuaTTChung);
            this.groupBox1.Controls.Add(this.btnThemTTChung);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.dtpNgaySuaChua);
            this.groupBox1.Controls.Add(this.cbbBienSoXe);
            this.groupBox1.Controls.Add(this.txtMaPSC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnXoaTTChung
            // 
            this.btnXoaTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTTChung.Location = new System.Drawing.Point(544, 78);
            this.btnXoaTTChung.Name = "btnXoaTTChung";
            this.btnXoaTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTTChung.TabIndex = 11;
            this.btnXoaTTChung.Text = "Xóa";
            // 
            // btnSuaTTChung
            // 
            this.btnSuaTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTTChung.Location = new System.Drawing.Point(544, 49);
            this.btnSuaTTChung.Name = "btnSuaTTChung";
            this.btnSuaTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTTChung.TabIndex = 10;
            this.btnSuaTTChung.Text = "Sửa";
            // 
            // btnThemTTChung
            // 
            this.btnThemTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTTChung.Location = new System.Drawing.Point(544, 20);
            this.btnThemTTChung.Name = "btnThemTTChung";
            this.btnThemTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnThemTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTTChung.TabIndex = 9;
            this.btnThemTTChung.Text = "Thêm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(362, 55);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 20);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // dtpNgaySuaChua
            // 
            this.dtpNgaySuaChua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySuaChua.Location = new System.Drawing.Point(123, 53);
            this.dtpNgaySuaChua.Name = "dtpNgaySuaChua";
            this.dtpNgaySuaChua.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySuaChua.TabIndex = 6;
            this.dtpNgaySuaChua.ValueChanged += new System.EventHandler(this.dtpNgaySuaChua_ValueChanged);
            // 
            // cbbBienSoXe
            // 
            this.cbbBienSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBienSoXe.FormattingEnabled = true;
            this.cbbBienSoXe.Location = new System.Drawing.Point(362, 26);
            this.cbbBienSoXe.Name = "cbbBienSoXe";
            this.cbbBienSoXe.Size = new System.Drawing.Size(121, 21);
            this.cbbBienSoXe.TabIndex = 5;
            // 
            // txtMaPSC
            // 
            this.txtMaPSC.Location = new System.Drawing.Point(123, 27);
            this.txtMaPSC.Name = "txtMaPSC";
            this.txtMaPSC.Size = new System.Drawing.Size(100, 20);
            this.txtMaPSC.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày sửa chữa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Biển số xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phiếu sửa chữa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemTTRieng);
            this.groupBox2.Controls.Add(this.btnSuaTTRieng);
            this.groupBox2.Controls.Add(this.btnXoaTTRieng);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cbbMaVTPT);
            this.groupBox2.Controls.Add(this.cbbNoiDung);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(4, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 133);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin riêng";
            // 
            // btnThemTTRieng
            // 
            this.btnThemTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTTRieng.Location = new System.Drawing.Point(547, 19);
            this.btnThemTTRieng.Name = "btnThemTTRieng";
            this.btnThemTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnThemTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTTRieng.TabIndex = 15;
            this.btnThemTTRieng.Text = "Thêm";
            // 
            // btnSuaTTRieng
            // 
            this.btnSuaTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTTRieng.Location = new System.Drawing.Point(547, 51);
            this.btnSuaTTRieng.Name = "btnSuaTTRieng";
            this.btnSuaTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTTRieng.TabIndex = 14;
            this.btnSuaTTRieng.Text = "Sửa";
            // 
            // btnXoaTTRieng
            // 
            this.btnXoaTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTTRieng.Location = new System.Drawing.Point(547, 85);
            this.btnXoaTTRieng.Name = "btnXoaTTRieng";
            this.btnXoaTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTTRieng.TabIndex = 13;
            this.btnXoaTTRieng.Text = "Xóa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "đơn vị tính";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(238, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "VNĐ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(123, 80);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 9;
            this.txtThanhTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThanhTien_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(362, 54);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(75, 20);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 51);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(49, 20);
            this.txtSoLuong.TabIndex = 7;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cbbMaVTPT
            // 
            this.cbbMaVTPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaVTPT.FormattingEnabled = true;
            this.cbbMaVTPT.Location = new System.Drawing.Point(362, 24);
            this.cbbMaVTPT.Name = "cbbMaVTPT";
            this.cbbMaVTPT.Size = new System.Drawing.Size(121, 21);
            this.cbbMaVTPT.TabIndex = 6;
            // 
            // cbbNoiDung
            // 
            this.cbbNoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNoiDung.FormattingEnabled = true;
            this.cbbNoiDung.Location = new System.Drawing.Point(123, 24);
            this.cbbNoiDung.Name = "cbbNoiDung";
            this.cbbNoiDung.Size = new System.Drawing.Size(121, 21);
            this.cbbNoiDung.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã vật tư phụ tùng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nội dung";
            // 
            // dgvTimTTRieng
            // 
            this.dgvTimTTRieng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTimTTRieng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimTTRieng.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimTTRieng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTimTTRieng.Location = new System.Drawing.Point(4, 483);
            this.dgvTimTTRieng.Name = "dgvTimTTRieng";
            this.dgvTimTTRieng.Size = new System.Drawing.Size(645, 131);
            this.dgvTimTTRieng.TabIndex = 13;
            // 
            // txtTimTTRieng
            // 
            this.txtTimTTRieng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimTTRieng.Location = new System.Drawing.Point(193, 456);
            this.txtTimTTRieng.Name = "txtTimTTRieng";
            this.txtTimTTRieng.Size = new System.Drawing.Size(456, 20);
            this.txtTimTTRieng.TabIndex = 12;
            // 
            // cbbTimTTRieng
            // 
            this.cbbTimTTRieng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbTimTTRieng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTTRieng.FormattingEnabled = true;
            this.cbbTimTTRieng.Items.AddRange(new object[] {
            "Nội dung",
            "Mã VTPT"});
            this.cbbTimTTRieng.Location = new System.Drawing.Point(55, 456);
            this.cbbTimTTRieng.Name = "cbbTimTTRieng";
            this.cbbTimTTRieng.Size = new System.Drawing.Size(132, 21);
            this.cbbTimTTRieng.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm theo";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(475, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 36;
            this.btnTim.Text = "Tìm";
            // 
            // txtTimDenSoTien
            // 
            this.txtTimDenSoTien.Location = new System.Drawing.Point(357, 9);
            this.txtTimDenSoTien.Name = "txtTimDenSoTien";
            this.txtTimDenSoTien.Size = new System.Drawing.Size(100, 20);
            this.txtTimDenSoTien.TabIndex = 35;
            this.txtTimDenSoTien.TextChanged += new System.EventHandler(this.txtTimDenSoTien_TextChanged);
            this.txtTimDenSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimDenSoTien_KeyPress);
            // 
            // txtTimTuSoTien
            // 
            this.txtTimTuSoTien.Location = new System.Drawing.Point(218, 9);
            this.txtTimTuSoTien.Name = "txtTimTuSoTien";
            this.txtTimTuSoTien.Size = new System.Drawing.Size(100, 20);
            this.txtTimTuSoTien.TabIndex = 34;
            this.txtTimTuSoTien.TextChanged += new System.EventHandler(this.txtTimTuSoTien_TextChanged);
            this.txtTimTuSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimTuSoTien_KeyPress);
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(190, 13);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 33;
            this.lbTu.Text = "Từ";
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(357, 10);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimDenNgay.TabIndex = 28;
            this.dtpTimDenNgay.ValueChanged += new System.EventHandler(this.dtpTimDenNgay_ValueChanged);
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(219, 10);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimTuNgay.TabIndex = 27;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(324, 13);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 12;
            this.lbDen.Text = "Đến";
            // 
            // frmPhieuSuaChua
            // 
            this.ClientSize = new System.Drawing.Size(666, 619);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.dtpTimDenNgay);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpTimTuNgay);
            this.Controls.Add(this.dgvTimTTRieng);
            this.Controls.Add(this.txtTimDenSoTien);
            this.Controls.Add(this.txtTimTTRieng);
            this.Controls.Add(this.txtTimTuSoTien);
            this.Controls.Add(this.cbbTimTTRieng);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTimTTChung);
            this.Controls.Add(this.txtTimTTChung);
            this.Controls.Add(this.cbbTimTTChung);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(682, 657);
            this.Name = "frmPhieuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiếu sửa chữa";
            this.Load += new System.EventHandler(this.frmPhieuSuaChua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTTChung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimTTRieng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimTTChung;
        private System.Windows.Forms.ComboBox cbbTimTTChung;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimTTChung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgaySuaChua;
        private System.Windows.Forms.ComboBox cbbBienSoXe;
        private System.Windows.Forms.TextBox txtMaPSC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbMaVTPT;
        private System.Windows.Forms.ComboBox cbbNoiDung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTimTTRieng;
        private System.Windows.Forms.TextBox txtTimTTRieng;
        private System.Windows.Forms.ComboBox cbbTimTTRieng;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.ButtonX btnXoaTTChung;
        private DevComponents.DotNetBar.ButtonX btnSuaTTChung;
        private DevComponents.DotNetBar.ButtonX btnThemTTChung;
        private DevComponents.DotNetBar.ButtonX btnThemTTRieng;
        private DevComponents.DotNetBar.ButtonX btnSuaTTRieng;
        private DevComponents.DotNetBar.ButtonX btnXoaTTRieng;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private System.Windows.Forms.TextBox txtTimDenSoTien;
        private System.Windows.Forms.TextBox txtTimTuSoTien;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.Label lbDen;
    }
}