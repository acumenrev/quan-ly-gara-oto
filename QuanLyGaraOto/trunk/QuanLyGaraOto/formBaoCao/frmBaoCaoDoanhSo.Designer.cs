namespace QuanLyGaraOto.formBaoCao
{
    partial class frmBaoCaoDoanhSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoDoanhSo));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.dgvKetQua = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXuatKetQua = new DevComponents.DotNetBar.ButtonX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(69, 18);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(77, 20);
            this.dtpThoiGian.TabIndex = 1;
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
            this.dgvKetQua.Location = new System.Drawing.Point(15, 58);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(603, 325);
            this.dgvKetQua.TabIndex = 3;
            // 
            // btnXuatKetQua
            // 
            this.btnXuatKetQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatKetQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatKetQua.Location = new System.Drawing.Point(172, 12);
            this.btnXuatKetQua.Name = "btnXuatKetQua";
            this.btnXuatKetQua.Size = new System.Drawing.Size(75, 38);
            this.btnXuatKetQua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatKetQua.TabIndex = 7;
            this.btnXuatKetQua.Text = "Xuất kết quả";
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(15, 423);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 38);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 8;
            this.btnIn.Text = "In";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXuatExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatExcel.Location = new System.Drawing.Point(115, 423);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(75, 38);
            this.btnXuatExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất ra tập tin Excel";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(210, 423);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongDoanhThu.Enabled = false;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(115, 389);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(100, 20);
            this.txtTongDoanhThu.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "VNĐ";
            // 
            // frmBaoCaoDoanhSo
            // 
            this.ClientSize = new System.Drawing.Size(630, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXuatKetQua);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(646, 511);
            this.Name = "frmBaoCaoDoanhSo";
            this.Text = "Báo cáo doanh số";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKetQua;
        private DevComponents.DotNetBar.ButtonX btnXuatKetQua;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnXuatExcel;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.Label label3;
    }
}