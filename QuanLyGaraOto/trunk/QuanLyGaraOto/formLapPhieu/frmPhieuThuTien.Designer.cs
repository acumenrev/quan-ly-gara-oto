﻿namespace QuanLyGaraOto.formLapPhieu
{
    partial class frmPhieuThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThuTien));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTim = new System.Windows.Forms.ComboBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvTim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbBienSoXe = new System.Windows.Forms.ComboBox();
            this.xEsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gARA1DataSet = new QuanLyGaraOto.GARA1DataSet();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaCSDL = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaCSDL = new DevComponents.DotNetBar.ButtonX();
            this.btnThemCSDL = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatPhieu = new DevComponents.DotNetBar.ButtonX();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbDen = new System.Windows.Forms.Label();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTimTu = new System.Windows.Forms.TextBox();
            this.txtTimDen = new System.Windows.Forms.TextBox();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.label6 = new System.Windows.Forms.Label();
            this.xEsTableAdapter = new QuanLyGaraOto.GARA1DataSetTableAdapters.XEsTableAdapter();
            this.btnTaoMoi = new DevComponents.DotNetBar.ButtonX();
            this.txtMaPTT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
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
            "Mã phiếu thu tiền",
            "Biển số xe",
            "Ngày thu",
            "Số tiền thu"});
            this.cbbTim.Location = new System.Drawing.Point(66, 25);
            this.cbbTim.Name = "cbbTim";
            this.cbbTim.Size = new System.Drawing.Size(121, 21);
            this.cbbTim.TabIndex = 1;
            this.cbbTim.SelectedIndexChanged += new System.EventHandler(this.cbbTim_SelectedIndexChanged);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(193, 26);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(360, 20);
            this.txtTim.TabIndex = 2;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
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
            this.dgvTim.Location = new System.Drawing.Point(15, 52);
            this.dgvTim.MultiSelect = false;
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(538, 155);
            this.dgvTim.TabIndex = 3;
            this.dgvTim.SelectionChanged += new System.EventHandler(this.dgvTim_SelectionChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phiếu thu tiền";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biển số xe";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày thu";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền thu";
            // 
            // cbbBienSoXe
            // 
            this.cbbBienSoXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbBienSoXe.DataSource = this.xEsBindingSource;
            this.cbbBienSoXe.DisplayMember = "BienSoXe";
            this.cbbBienSoXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBienSoXe.FormattingEnabled = true;
            this.cbbBienSoXe.Location = new System.Drawing.Point(107, 256);
            this.cbbBienSoXe.Name = "cbbBienSoXe";
            this.cbbBienSoXe.Size = new System.Drawing.Size(100, 21);
            this.cbbBienSoXe.TabIndex = 9;
            this.cbbBienSoXe.ValueMember = "BienSoXe";
            // 
            // xEsBindingSource
            // 
            this.xEsBindingSource.DataMember = "XEs";
            this.xEsBindingSource.DataSource = this.gARA1DataSet;
            // 
            // gARA1DataSet
            // 
            this.gARA1DataSet.DataSetName = "GARA1DataSet";
            this.gARA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThu.Location = new System.Drawing.Point(107, 289);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(100, 20);
            this.dtpNgayThu.TabIndex = 10;
            this.dtpNgayThu.ValueChanged += new System.EventHandler(this.dtpNgayThu_ValueChanged);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSoTienThu.Location = new System.Drawing.Point(107, 320);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(100, 20);
            this.txtSoTienThu.TabIndex = 11;
            this.txtSoTienThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienThu_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(433, 369);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaCSDL
            // 
            this.btnSuaCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaCSDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSuaCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaCSDL.Location = new System.Drawing.Point(330, 369);
            this.btnSuaCSDL.Name = "btnSuaCSDL";
            this.btnSuaCSDL.Size = new System.Drawing.Size(75, 38);
            this.btnSuaCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSuaCSDL.TabIndex = 24;
            this.btnSuaCSDL.Text = "Sửa";
            this.btnSuaCSDL.Click += new System.EventHandler(this.btnSuaCSDL_Click);
            // 
            // btnXoaCSDL
            // 
            this.btnXoaCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaCSDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoaCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaCSDL.Location = new System.Drawing.Point(227, 369);
            this.btnXoaCSDL.Name = "btnXoaCSDL";
            this.btnXoaCSDL.Size = new System.Drawing.Size(75, 38);
            this.btnXoaCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoaCSDL.TabIndex = 23;
            this.btnXoaCSDL.Text = "Xóa";
            this.btnXoaCSDL.Click += new System.EventHandler(this.btnXoaCSDL_Click);
            // 
            // btnThemCSDL
            // 
            this.btnThemCSDL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemCSDL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemCSDL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemCSDL.Location = new System.Drawing.Point(123, 369);
            this.btnThemCSDL.Name = "btnThemCSDL";
            this.btnThemCSDL.Size = new System.Drawing.Size(75, 38);
            this.btnThemCSDL.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThemCSDL.TabIndex = 22;
            this.btnThemCSDL.Text = "Thêm";
            this.btnThemCSDL.Click += new System.EventHandler(this.btnThemCSDL_Click);
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatPhieu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatPhieu.Location = new System.Drawing.Point(15, 369);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(75, 38);
            this.btnXuatPhieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatPhieu.TabIndex = 21;
            this.btnXuatPhieu.Text = "Xuất phiếu";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(193, 29);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 26;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(327, 29);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 27;
            this.lbDen.Text = "Đến";
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(221, 25);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimTuNgay.TabIndex = 28;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(360, 26);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(100, 20);
            this.dtpTimDenNgay.TabIndex = 29;
            this.dtpTimDenNgay.ValueChanged += new System.EventHandler(this.dtpTimDenNgay_ValueChanged);
            // 
            // txtTimTu
            // 
            this.txtTimTu.Location = new System.Drawing.Point(219, 26);
            this.txtTimTu.Name = "txtTimTu";
            this.txtTimTu.Size = new System.Drawing.Size(100, 20);
            this.txtTimTu.TabIndex = 30;
            this.txtTimTu.TextChanged += new System.EventHandler(this.txtTimTuSoTien_TextChanged);
            this.txtTimTu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimTuSoTien_KeyPress);
            // 
            // txtTimDen
            // 
            this.txtTimDen.Location = new System.Drawing.Point(360, 26);
            this.txtTimDen.Name = "txtTimDen";
            this.txtTimDen.Size = new System.Drawing.Size(100, 20);
            this.txtTimDen.TabIndex = 31;
            this.txtTimDen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimDenSoTien_KeyPress);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(478, 23);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 32;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "VNĐ";
            // 
            // xEsTableAdapter
            // 
            this.xEsTableAdapter.ClearBeforeFill = true;
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTaoMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTaoMoi.Location = new System.Drawing.Point(330, 302);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 38);
            this.btnTaoMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTaoMoi.TabIndex = 34;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // txtMaPTT
            // 
            this.txtMaPTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaPTT.Location = new System.Drawing.Point(107, 226);
            this.txtMaPTT.Name = "txtMaPTT";
            this.txtMaPTT.Size = new System.Drawing.Size(100, 20);
            this.txtMaPTT.TabIndex = 8;
            // 
            // frmPhieuThuTien
            // 
            this.ClientSize = new System.Drawing.Size(565, 433);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimDen);
            this.Controls.Add(this.txtTimTu);
            this.Controls.Add(this.dtpTimDenNgay);
            this.Controls.Add(this.dtpTimTuNgay);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaCSDL);
            this.Controls.Add(this.btnXoaCSDL);
            this.Controls.Add(this.btnThemCSDL);
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.txtSoTienThu);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.cbbBienSoXe);
            this.Controls.Add(this.txtMaPTT);
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
            this.MinimumSize = new System.Drawing.Size(581, 471);
            this.Name = "frmPhieuThuTien";
            this.Text = "Phiếu thu tiền";
            this.Load += new System.EventHandler(this.frmPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xEsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbBienSoXe;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnSuaCSDL;
        private DevComponents.DotNetBar.ButtonX btnXoaCSDL;
        private DevComponents.DotNetBar.ButtonX btnThemCSDL;
        private DevComponents.DotNetBar.ButtonX btnXuatPhieu;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private System.Windows.Forms.TextBox txtTimTu;
        private System.Windows.Forms.TextBox txtTimDen;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private System.Windows.Forms.Label label6;
        private GARA1DataSet gARA1DataSet;
        private System.Windows.Forms.BindingSource xEsBindingSource;
        private GARA1DataSetTableAdapters.XEsTableAdapter xEsTableAdapter;
        private DevComponents.DotNetBar.ButtonX btnTaoMoi;
        private System.Windows.Forms.TextBox txtMaPTT;
    }
}