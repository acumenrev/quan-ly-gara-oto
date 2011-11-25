namespace QuanLyGaraOto.formCSDL
{
    partial class frmTienCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTienCong));
            this.dgvTim = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTienCong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
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
            this.dgvTim.Location = new System.Drawing.Point(15, 32);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.Size = new System.Drawing.Size(456, 148);
            this.dgvTim.TabIndex = 51;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(169, 6);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(302, 20);
            this.txtTim.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Tìm";
            // 
            // cbbTim
            // 
            this.cbbTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTim.FormattingEnabled = true;
            this.cbbTim.Items.AddRange(new object[] {
            "Nội dung",
            "Tiền công"});
            this.cbbTim.Location = new System.Drawing.Point(42, 6);
            this.cbbTim.Name = "cbbTim";
            this.cbbTim.Size = new System.Drawing.Size(121, 21);
            this.cbbTim.TabIndex = 52;
            this.cbbTim.SelectedIndexChanged += new System.EventHandler(this.cbbTim_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tiền công";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(73, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 69);
            this.textBox1.TabIndex = 55;
            // 
            // txtTienCong
            // 
            this.txtTienCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienCong.Location = new System.Drawing.Point(73, 271);
            this.txtTienCong.Name = "txtTienCong";
            this.txtTienCong.Size = new System.Drawing.Size(100, 20);
            this.txtTienCong.TabIndex = 56;
            this.txtTienCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienCong_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "VNĐ";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(73, 297);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(169, 297);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(264, 297);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 60;
            this.btnXoa.Text = "Xóa";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Location = new System.Drawing.Point(179, 9);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(20, 13);
            this.lbTu.TabIndex = 61;
            this.lbTu.Text = "Từ";
            // 
            // lbDen
            // 
            this.lbDen.AutoSize = true;
            this.lbDen.Location = new System.Drawing.Point(312, 9);
            this.lbDen.Name = "lbDen";
            this.lbDen.Size = new System.Drawing.Size(27, 13);
            this.lbDen.TabIndex = 62;
            this.lbDen.Text = "Đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(205, 6);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(100, 20);
            this.txtTu.TabIndex = 63;
            this.txtTu.TextChanged += new System.EventHandler(this.txtTu_TextChanged);
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(345, 6);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(100, 20);
            this.txtDen.TabIndex = 64;
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(454, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(54, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 65;
            this.btnTim.Text = "Tìm";
            // 
            // frmTienCong
            // 
            this.ClientSize = new System.Drawing.Size(520, 333);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtDen);
            this.Controls.Add(this.txtTu);
            this.Controls.Add(this.lbDen);
            this.Controls.Add(this.lbTu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTienCong);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbTim);
            this.Controls.Add(this.dgvTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(536, 371);
            this.Name = "frmTienCong";
            this.Text = "Tiền công";
            this.Load += new System.EventHandler(this.frmTienCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTienCong;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbDen;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private DevComponents.DotNetBar.ButtonX btnTim;
    }
}