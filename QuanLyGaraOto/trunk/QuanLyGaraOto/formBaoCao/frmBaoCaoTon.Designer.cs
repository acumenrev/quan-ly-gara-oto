namespace QuanLyGaraOto.formBaoCao
{
    partial class frmBaoCaoTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTon));
            this.dgvKetQua = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXuatBaoCao = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatKetQua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.gARA1DataSet = new QuanLyGaraOto.GARA1DataSet();
            this.dgvTim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.dtpTimDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTimTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDen = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.cbbTim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaVTPT = new System.Windows.Forms.ComboBox();
            this.vATTUPHUTUNGsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUPHUTUNGsTableAdapter = new QuanLyGaraOto.GARA1DataSetTableAdapters.VATTUPHUTUNGsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKetQua.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvKetQua.Location = new System.Drawing.Point(27, 221);
            this.dgvKetQua.MultiSelect = false;
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(578, 80);
            this.dgvKetQua.TabIndex = 2;
            this.dgvKetQua.SelectionChanged += new System.EventHandler(this.dgvKetQua_SelectionChanged);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatBaoCao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(27, 307);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(75, 38);
            this.btnXuatBaoCao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatBaoCao.TabIndex = 3;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(270, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXuatKetQua
            // 
            this.btnXuatKetQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatKetQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatKetQua.Location = new System.Drawing.Point(328, 177);
            this.btnXuatKetQua.Name = "btnXuatKetQua";
            this.btnXuatKetQua.Size = new System.Drawing.Size(75, 38);
            this.btnXuatKetQua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatKetQua.TabIndex = 6;
            this.btnXuatKetQua.Text = "Xuất kết quả";
            this.btnXuatKetQua.Click += new System.EventHandler(this.btnXuatKetQua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(108, 307);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 38);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(189, 307);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 38);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gARA1DataSet
            // 
            this.gARA1DataSet.DataSetName = "GARA1DataSet";
            this.gARA1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTim
            // 
            this.dgvTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTim.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTim.Location = new System.Drawing.Point(27, 58);
            this.dgvTim.MultiSelect = false;
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTim.Size = new System.Drawing.Size(578, 112);
            this.dgvTim.TabIndex = 11;
            this.dgvTim.SelectionChanged += new System.EventHandler(this.dgvTim_SelectionChanged);
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(473, 20);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 45;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpTimDenNgay
            // 
            this.dtpTimDenNgay.CustomFormat = "MM/yyyy";
            this.dtpTimDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimDenNgay.Location = new System.Drawing.Point(370, 20);
            this.dtpTimDenNgay.Name = "dtpTimDenNgay";
            this.dtpTimDenNgay.Size = new System.Drawing.Size(68, 20);
            this.dtpTimDenNgay.TabIndex = 44;
            this.dtpTimDenNgay.ValueChanged += new System.EventHandler(this.dtpTimDenNgay_ValueChanged);
            // 
            // dtpTimTuNgay
            // 
            this.dtpTimTuNgay.CustomFormat = "MM/yyyy";
            this.dtpTimTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimTuNgay.Location = new System.Drawing.Point(229, 20);
            this.dtpTimTuNgay.Name = "dtpTimTuNgay";
            this.dtpTimTuNgay.Size = new System.Drawing.Size(68, 20);
            this.dtpTimTuNgay.TabIndex = 43;
            this.dtpTimTuNgay.ValueChanged += new System.EventHandler(this.dtpTimTuNgay_ValueChanged);
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(325, 23);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 42;
            this.lbDen.Text = "Đến";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(189, 22);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 41;
            this.lbTu.Text = "Từ";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(184, 20);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(376, 20);
            this.txtTim.TabIndex = 40;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // cbbTim
            // 
            this.cbbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTim.FormattingEnabled = true;
            this.cbbTim.Items.AddRange(new object[] {
            "Mã báo cáo",
            "Ngày tháng"});
            this.cbbTim.Location = new System.Drawing.Point(78, 19);
            this.cbbTim.Name = "cbbTim";
            this.cbbTim.Size = new System.Drawing.Size(100, 21);
            this.cbbTim.TabIndex = 39;
            this.cbbTim.SelectedIndexChanged += new System.EventHandler(this.cbbTim_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tìm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(81, 181);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(75, 20);
            this.dtpThoiGian.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Mã VTPT";
            // 
            // cbbMaVTPT
            // 
            this.cbbMaVTPT.DataSource = this.vATTUPHUTUNGsBindingSource;
            this.cbbMaVTPT.DisplayMember = "MaVTPT";
            this.cbbMaVTPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaVTPT.FormattingEnabled = true;
            this.cbbMaVTPT.Location = new System.Drawing.Point(218, 182);
            this.cbbMaVTPT.Name = "cbbMaVTPT";
            this.cbbMaVTPT.Size = new System.Drawing.Size(93, 21);
            this.cbbMaVTPT.TabIndex = 47;
            this.cbbMaVTPT.ValueMember = "MaVTPT";
            // 
            // vATTUPHUTUNGsBindingSource
            // 
            this.vATTUPHUTUNGsBindingSource.DataMember = "VATTUPHUTUNGs";
            this.vATTUPHUTUNGsBindingSource.DataSource = this.gARA1DataSet;
            // 
            // vATTUPHUTUNGsTableAdapter
            // 
            this.vATTUPHUTUNGsTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoTon
            // 
            this.ClientSize = new System.Drawing.Size(617, 357);
            this.Controls.Add(this.cbbMaVTPT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpTimDenNgay);
            this.Controls.Add(this.dtpTimTuNgay);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.cbbTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXuatKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(633, 300);
            this.Name = "frmBaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo tồn";
            this.Load += new System.EventHandler(this.frmBaoCaoTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gARA1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUPHUTUNGsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKetQua;
        private DevComponents.DotNetBar.ButtonX btnXuatBaoCao;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXuatKetQua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private GARA1DataSet gARA1DataSet;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTim;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private System.Windows.Forms.DateTimePicker dtpTimDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTimTuNgay;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ComboBox cbbTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaVTPT;
        private System.Windows.Forms.BindingSource vATTUPHUTUNGsBindingSource;
        private GARA1DataSetTableAdapters.VATTUPHUTUNGsTableAdapter vATTUPHUTUNGsTableAdapter;
    }
}