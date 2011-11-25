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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoTon));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.dgvKetQua = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatRaFile = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatKetQua = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "MM/yyyy";
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(81, 16);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(75, 20);
            this.dtpThoiGian.TabIndex = 1;
            // 
            // dgvKetQua
            // 
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
            this.dgvKetQua.Location = new System.Drawing.Point(27, 56);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.Size = new System.Drawing.Size(578, 301);
            this.dgvKetQua.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Location = new System.Drawing.Point(27, 378);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 38);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            // 
            // btnXuatRaFile
            // 
            this.btnXuatRaFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatRaFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatRaFile.Location = new System.Drawing.Point(121, 378);
            this.btnXuatRaFile.Name = "btnXuatRaFile";
            this.btnXuatRaFile.Size = new System.Drawing.Size(79, 38);
            this.btnXuatRaFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatRaFile.TabIndex = 4;
            this.btnXuatRaFile.Text = "Xuất ra tập tin Excel";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(222, 378);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXuatKetQua
            // 
            this.btnXuatKetQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatKetQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatKetQua.Location = new System.Drawing.Point(176, 12);
            this.btnXuatKetQua.Name = "btnXuatKetQua";
            this.btnXuatKetQua.Size = new System.Drawing.Size(75, 38);
            this.btnXuatKetQua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXuatKetQua.TabIndex = 6;
            this.btnXuatKetQua.Text = "Xuất kết quả";
            // 
            // frmBaoCaoTon
            // 
            this.ClientSize = new System.Drawing.Size(617, 419);
            this.Controls.Add(this.btnXuatKetQua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatRaFile);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(633, 457);
            this.Name = "frmBaoCaoTon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo tồn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKetQua;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnXuatRaFile;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXuatKetQua;
    }
}