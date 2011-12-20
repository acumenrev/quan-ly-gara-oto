namespace QuanLyGaraOto.formLapPhieu
{
    partial class frmPhieuNhapVTPT
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhapVTPT));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimTTChung = new System.Windows.Forms.ComboBox();
            this.txtTimTTChung = new System.Windows.Forms.TextBox();
            this.dgvThongTinChung = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new DevComponents.DotNetBar.ButtonX();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.btnXoaTTChung = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTTChung = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTTChung = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.cbbMaVTPT = new System.Windows.Forms.ComboBox();
            this.vATTUPHUTUNGsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gARA1DataSet = new QuanLyGaraOto.GARA1DataSet();
            this.btnThemTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaTTRieng = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongTinRieng = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTimRieng = new System.Windows.Forms.TextBox();
            this.cbbTimRieng = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXuatPhieu = new DevComponents.DotNetBar.ButtonX();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDen = new System.Windows.Forms.Label();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.vATTUPHUTUNGsTableAdapter = new QuanLyGaraOto.GARA1DataSetTableAdapters.VATTUPHUTUNGsTableAdapter();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinRieng)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm theo";
            // 
            // cbbTimTTChung
            // 
            this.cbbTimTTChung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimTTChung.FormattingEnabled = true;
            this.cbbTimTTChung.Items.AddRange(new object[] {
            "Mã phiếu nhập",
            "Ngày nhập"});
            this.cbbTimTTChung.Location = new System.Drawing.Point(66, 6);
            this.cbbTimTTChung.Name = "cbbTimTTChung";
            this.cbbTimTTChung.Size = new System.Drawing.Size(108, 21);
            this.cbbTimTTChung.TabIndex = 1;
            this.cbbTimTTChung.SelectedIndexChanged += new System.EventHandler(this.cbbTimTTChung_SelectedIndexChanged);
            // 
            // txtTimTTChung
            // 
            this.txtTimTTChung.Location = new System.Drawing.Point(180, 6);
            this.txtTimTTChung.Name = "txtTimTTChung";
            this.txtTimTTChung.Size = new System.Drawing.Size(233, 20);
            this.txtTimTTChung.TabIndex = 2;
            this.txtTimTTChung.TextChanged += new System.EventHandler(this.txtTimTTChung_TextChanged);
            // 
            // dgvThongTinChung
            // 
            this.dgvThongTinChung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvThongTinChung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinChung.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinChung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThongTinChung.Location = new System.Drawing.Point(15, 33);
            this.dgvThongTinChung.MultiSelect = false;
            this.dgvThongTinChung.Name = "dgvThongTinChung";
            this.dgvThongTinChung.ReadOnly = true;
            this.dgvThongTinChung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinChung.Size = new System.Drawing.Size(645, 226);
            this.dgvThongTinChung.TabIndex = 3;
            this.dgvThongTinChung.SelectionChanged += new System.EventHandler(this.dgvThongTinChung_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnTaoMoi);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.txtMaPhieuNhap);
            this.groupBox1.Controls.Add(this.btnXoaTTChung);
            this.groupBox1.Controls.Add(this.btnSuaTTChung);
            this.groupBox1.Controls.Add(this.btnThemTTChung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaoMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTaoMoi.Location = new System.Drawing.Point(274, 29);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTaoMoi.TabIndex = 7;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(90, 76);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayNhap.TabIndex = 6;
            this.dtpNgayNhap.ValueChanged += new System.EventHandler(this.dtpNgayNhap_ValueChanged);
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(90, 26);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhieuNhap.TabIndex = 5;
            // 
            // btnXoaTTChung
            // 
            this.btnXoaTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTTChung.Location = new System.Drawing.Point(355, 87);
            this.btnXoaTTChung.Name = "btnXoaTTChung";
            this.btnXoaTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTTChung.TabIndex = 4;
            this.btnXoaTTChung.Text = "Xóa";
            this.btnXoaTTChung.Click += new System.EventHandler(this.btnXoaTTChung_Click);
            // 
            // btnSuaTTChung
            // 
            this.btnSuaTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTTChung.Location = new System.Drawing.Point(355, 58);
            this.btnSuaTTChung.Name = "btnSuaTTChung";
            this.btnSuaTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTTChung.TabIndex = 3;
            this.btnSuaTTChung.Text = "Sửa";
            this.btnSuaTTChung.Click += new System.EventHandler(this.btnSuaTTChung_Click);
            // 
            // btnThemTTChung
            // 
            this.btnThemTTChung.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTTChung.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTTChung.Location = new System.Drawing.Point(355, 29);
            this.btnThemTTChung.Name = "btnThemTTChung";
            this.btnThemTTChung.Size = new System.Drawing.Size(75, 23);
            this.btnThemTTChung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTTChung.TabIndex = 2;
            this.btnThemTTChung.Text = "Thêm";
            this.btnThemTTChung.Click += new System.EventHandler(this.btnThemTTChung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDonGiaNhap);
            this.groupBox2.Controls.Add(this.txtSoLuongNhap);
            this.groupBox2.Controls.Add(this.cbbMaVTPT);
            this.groupBox2.Controls.Add(this.btnThemTTRieng);
            this.groupBox2.Controls.Add(this.btnSuaTTRieng);
            this.groupBox2.Controls.Add(this.btnXoaTTRieng);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(666, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin riêng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "VNĐ";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(109, 88);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtDonGiaNhap.TabIndex = 10;
            this.txtDonGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaNhap_KeyPress);
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(109, 58);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuongNhap.TabIndex = 9;
            this.txtSoLuongNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongNhap_KeyPress);
            // 
            // cbbMaVTPT
            // 
            this.cbbMaVTPT.DataSource = this.vATTUPHUTUNGsBindingSource;
            this.cbbMaVTPT.DisplayMember = "MaVTPT";
            this.cbbMaVTPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaVTPT.FormattingEnabled = true;
            this.cbbMaVTPT.Location = new System.Drawing.Point(109, 25);
            this.cbbMaVTPT.Name = "cbbMaVTPT";
            this.cbbMaVTPT.Size = new System.Drawing.Size(100, 21);
            this.cbbMaVTPT.TabIndex = 8;
            this.cbbMaVTPT.ValueMember = "MaVTPT";
            // 
            // vATTUPHUTUNGsBindingSource
            // 
            this.vATTUPHUTUNGsBindingSource.DataMember = "VATTUPHUTUNGs";
            this.vATTUPHUTUNGsBindingSource.DataSource = this.gARA1DataSet;
            // 
            // gARA1DataSet
            // 
            this.gARA1DataSet.DataSetName = "GARA1DataSet";
            this.gARA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThemTTRieng
            // 
            this.btnThemTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTTRieng.Location = new System.Drawing.Point(355, 23);
            this.btnThemTTRieng.Name = "btnThemTTRieng";
            this.btnThemTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnThemTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemTTRieng.TabIndex = 7;
            this.btnThemTTRieng.Text = "Thêm";
            this.btnThemTTRieng.Click += new System.EventHandler(this.btnThemTTRieng_Click);
            // 
            // btnSuaTTRieng
            // 
            this.btnSuaTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTTRieng.Location = new System.Drawing.Point(355, 52);
            this.btnSuaTTRieng.Name = "btnSuaTTRieng";
            this.btnSuaTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaTTRieng.TabIndex = 6;
            this.btnSuaTTRieng.Text = "Sửa";
            this.btnSuaTTRieng.Click += new System.EventHandler(this.btnSuaTTRieng_Click);
            // 
            // btnXoaTTRieng
            // 
            this.btnXoaTTRieng.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTTRieng.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTTRieng.Location = new System.Drawing.Point(355, 81);
            this.btnXoaTTRieng.Name = "btnXoaTTRieng";
            this.btnXoaTTRieng.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTTRieng.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaTTRieng.TabIndex = 5;
            this.btnXoaTTRieng.Text = "Xóa";
            this.btnXoaTTRieng.Click += new System.EventHandler(this.btnXoaTTRieng_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số lượng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã vật tư phụ tùng";
            // 
            // dgvThongTinRieng
            // 
            this.dgvThongTinRieng.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTinRieng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinRieng.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinRieng.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThongTinRieng.Location = new System.Drawing.Point(666, 33);
            this.dgvThongTinRieng.MultiSelect = false;
            this.dgvThongTinRieng.Name = "dgvThongTinRieng";
            this.dgvThongTinRieng.ReadOnly = true;
            this.dgvThongTinRieng.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinRieng.Size = new System.Drawing.Size(655, 226);
            this.dgvThongTinRieng.TabIndex = 9;
            this.dgvThongTinRieng.SelectionChanged += new System.EventHandler(this.dgvThongTinRieng_SelectionChanged);
            // 
            // txtTimRieng
            // 
            this.txtTimRieng.Location = new System.Drawing.Point(845, 7);
            this.txtTimRieng.Name = "txtTimRieng";
            this.txtTimRieng.Size = new System.Drawing.Size(265, 20);
            this.txtTimRieng.TabIndex = 8;
            this.txtTimRieng.TextChanged += new System.EventHandler(this.txtTimRieng_TextChanged);
            // 
            // cbbTimRieng
            // 
            this.cbbTimRieng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimRieng.FormattingEnabled = true;
            this.cbbTimRieng.Items.AddRange(new object[] {
            "Mã vật tư phụ tùng"});
            this.cbbTimRieng.Location = new System.Drawing.Point(717, 6);
            this.cbbTimRieng.Name = "cbbTimRieng";
            this.cbbTimRieng.Size = new System.Drawing.Size(122, 21);
            this.cbbTimRieng.TabIndex = 11;
            this.cbbTimRieng.SelectedIndexChanged += new System.EventHandler(this.cbbTimRieng_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tìm theo";
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatPhieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatPhieu.Location = new System.Drawing.Point(24, 431);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(75, 23);
            this.btnXuatPhieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatPhieu.TabIndex = 12;
            this.btnXuatPhieu.Text = "Xuất phiếu";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(185, 9);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 7;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(296, 9);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 8;
            this.lbDen.Text = "Đến";
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(211, 7);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(79, 20);
            this.dtpTimTuNgay.TabIndex = 7;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(329, 6);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(79, 20);
            this.dtpTimDenNgay.TabIndex = 8;
            this.dtpTimDenNgay.ValueChanged += new System.EventHandler(this.dtpTimDenNgay_ValueChanged);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(419, 6);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(43, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // vATTUPHUTUNGsTableAdapter
            // 
            this.vATTUPHUTUNGsTableAdapter.ClearBeforeFill = true;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(105, 431);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmPhieuNhapVTPT
            // 
            this.ClientSize = new System.Drawing.Size(1325, 479);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.dtpTimDenNgay);
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.dtpTimTuNgay);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.cbbTimRieng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvThongTinRieng);
            this.Controls.Add(this.txtTimRieng);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongTinChung);
            this.Controls.Add(this.txtTimTTChung);
            this.Controls.Add(this.cbbTimTTChung);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1341, 517);
            this.Name = "frmPhieuNhapVTPT";
            this.Text = "Phiếu nhập vật tư phụ tùng";
            this.Load += new System.EventHandler(this.frmPhieuNhapVTPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinRieng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTimTTChung;
        private System.Windows.Forms.TextBox txtTimTTChung;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThongTinChung;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private DevComponents.DotNetBar.ButtonX btnXoaTTChung;
        private DevComponents.DotNetBar.ButtonX btnSuaTTChung;
        private DevComponents.DotNetBar.ButtonX btnThemTTChung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.ComboBox cbbMaVTPT;
        private DevComponents.DotNetBar.ButtonX btnThemTTRieng;
        private DevComponents.DotNetBar.ButtonX btnSuaTTRieng;
        private DevComponents.DotNetBar.ButtonX btnXoaTTRieng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThongTinRieng;
        private System.Windows.Forms.TextBox txtTimRieng;
        private System.Windows.Forms.ComboBox cbbTimRieng;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.ButtonX btnXuatPhieu;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private GARA1DataSet gARA1DataSet;
        private System.Windows.Forms.BindingSource vATTUPHUTUNGsBindingSource;
        private GARA1DataSetTableAdapters.VATTUPHUTUNGsTableAdapter vATTUPHUTUNGsTableAdapter;
        private DevComponents.DotNetBar.ButtonX btnTaoMoi;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}