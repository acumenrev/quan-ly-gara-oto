namespace QuanLyGaraOto.formCSDL
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.btnSuaCSDL = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaCSDL = new DevComponents.DotNetBar.ButtonX();
            this.hIEUXEsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gARA1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gARA1DataSet = new QuanLyGaraOto.GARA1DataSet();
            this.dgvTim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbbTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.hIEUXEsTableAdapter = new QuanLyGaraOto.GARA1DataSetTableAdapters.HIEUXEsTableAdapter();
            this.txtTienNoTu = new System.Windows.Forms.TextBox();
            this.txtTienNoDen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpNgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cbbHieuXe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenChuXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(461, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(346, 7);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimDenNgay.TabIndex = 3;
            this.dtpTimDenNgay.ValueChanged += new System.EventHandler(this.dtpTimDenNgay_ValueChanged);
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(206, 7);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimTuNgay.TabIndex = 2;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(313, 10);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 62;
            this.lbDen.Text = "Đến";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(177, 9);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 61;
            this.lbTu.Text = "Từ";
            // 
            // btnSuaCSDL
            // 
            this.btnSuaCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaCSDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaCSDL.Location = new System.Drawing.Point(221, 328);
            this.btnSuaCSDL.Name = "btnSuaCSDL";
            this.btnSuaCSDL.Size = new System.Drawing.Size(75, 38);
            this.btnSuaCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaCSDL.TabIndex = 15;
            this.btnSuaCSDL.Text = "Sửa";
            this.btnSuaCSDL.Click += new System.EventHandler(this.btnSuaCSDL_Click);
            // 
            // btnXoaCSDL
            // 
            this.btnXoaCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaCSDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaCSDL.Location = new System.Drawing.Point(140, 328);
            this.btnXoaCSDL.Name = "btnXoaCSDL";
            this.btnXoaCSDL.Size = new System.Drawing.Size(75, 38);
            this.btnXoaCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaCSDL.TabIndex = 14;
            this.btnXoaCSDL.Text = "Xóa";
            this.btnXoaCSDL.Click += new System.EventHandler(this.btnXoaCSDL_Click);
            // 
            // hIEUXEsBindingSource
            // 
            this.hIEUXEsBindingSource.DataMember = "HIEUXEs";
            this.hIEUXEsBindingSource.DataSource = this.gARA1DataSetBindingSource;
            // 
            // gARA1DataSetBindingSource
            // 
            this.gARA1DataSetBindingSource.DataSource = this.gARA1DataSet;
            this.gARA1DataSetBindingSource.Position = 0;
            // 
            // gARA1DataSet
            // 
            this.gARA1DataSet.DataSetName = "GARA1DataSet";
            this.gARA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dgvTim.Location = new System.Drawing.Point(15, 33);
            this.dgvTim.MultiSelect = false;
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(548, 158);
            this.dgvTim.TabIndex = 41;
            this.dgvTim.SelectionChanged += new System.EventHandler(this.dgvTim_SelectionChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(172, 7);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(376, 20);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // cbbTim
            // 
            this.cbbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTim.FormattingEnabled = true;
            this.cbbTim.Items.AddRange(new object[] {
            "Tên chủ xe",
            "Hiệu xe",
            "Biển số",
            "Địa chỉ",
            "Ngày tiếp nhận"});
            this.cbbTim.Location = new System.Drawing.Point(66, 6);
            this.cbbTim.Name = "cbbTim";
            this.cbbTim.Size = new System.Drawing.Size(100, 21);
            this.cbbTim.TabIndex = 0;
            this.cbbTim.SelectedIndexChanged += new System.EventHandler(this.cbbTim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm theo";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Tiền nợ";
            // 
            // txtTienNo
            // 
            this.txtTienNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienNo.Location = new System.Drawing.Point(263, 276);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.Size = new System.Drawing.Size(100, 20);
            this.txtTienNo.TabIndex = 12;
            // 
            // hIEUXEsTableAdapter
            // 
            this.hIEUXEsTableAdapter.ClearBeforeFill = true;
            // 
            // txtTienNoTu
            // 
            this.txtTienNoTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienNoTu.Location = new System.Drawing.Point(206, 7);
            this.txtTienNoTu.Name = "txtTienNoTu";
            this.txtTienNoTu.Size = new System.Drawing.Size(100, 20);
            this.txtTienNoTu.TabIndex = 2;
            // 
            // txtTienNoDen
            // 
            this.txtTienNoDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienNoDen.Location = new System.Drawing.Point(346, 7);
            this.txtTienNoDen.Name = "txtTienNoDen";
            this.txtTienNoDen.Size = new System.Drawing.Size(100, 20);
            this.txtTienNoDen.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Location = new System.Drawing.Point(263, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Email";
            // 
            // dtpNgayTiepNhan
            // 
            this.dtpNgayTiepNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpNgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTiepNhan.Location = new System.Drawing.Point(98, 250);
            this.dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            this.dtpNgayTiepNhan.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayTiepNhan.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDienThoai.Location = new System.Drawing.Point(98, 277);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(100, 20);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDiaChi.Location = new System.Drawing.Point(263, 225);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // cbbHieuXe
            // 
            this.cbbHieuXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbHieuXe.DataSource = this.hIEUXEsBindingSource;
            this.cbbHieuXe.DisplayMember = "HieuXe";
            this.cbbHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHieuXe.FormattingEnabled = true;
            this.cbbHieuXe.Location = new System.Drawing.Point(96, 224);
            this.cbbHieuXe.Name = "cbbHieuXe";
            this.cbbHieuXe.Size = new System.Drawing.Size(100, 21);
            this.cbbHieuXe.TabIndex = 7;
            this.cbbHieuXe.ValueMember = "HieuXe";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Ngày tiếp nhận";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Hiệu xe";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBienSo.Location = new System.Drawing.Point(96, 201);
            this.txtBienSo.MaxLength = 10;
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(100, 20);
            this.txtBienSo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Biển số";
            // 
            // txtTenChuXe
            // 
            this.txtTenChuXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTenChuXe.Location = new System.Drawing.Point(263, 202);
            this.txtTenChuXe.Name = "txtTenChuXe";
            this.txtTenChuXe.Size = new System.Drawing.Size(100, 20);
            this.txtTenChuXe.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên chủ xe";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(302, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 81;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmXe
            // 
            this.ClientSize = new System.Drawing.Size(566, 378);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpNgayTiepNhan);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbbHieuXe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBienSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenChuXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTienNoDen);
            this.Controls.Add(this.txtTienNoTu);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpTimDenNgay);
            this.Controls.Add(this.dtpTimTuNgay);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnSuaCSDL);
            this.Controls.Add(this.btnXoaCSDL);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbbTim);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(582, 416);
            this.Name = "frmXe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hIEUXEsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnTim;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbTu;
        private DevComponents.DotNetBar.ButtonX btnSuaCSDL;
        private DevComponents.DotNetBar.ButtonX btnXoaCSDL;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbbTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.BindingSource gARA1DataSetBindingSource;
        private GARA1DataSet gARA1DataSet;
        private System.Windows.Forms.BindingSource hIEUXEsBindingSource;
        private GARA1DataSetTableAdapters.HIEUXEsTableAdapter hIEUXEsTableAdapter;
        private System.Windows.Forms.TextBox txtTienNoTu;
        private System.Windows.Forms.TextBox txtTienNoDen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cbbHieuXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenChuXe;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}