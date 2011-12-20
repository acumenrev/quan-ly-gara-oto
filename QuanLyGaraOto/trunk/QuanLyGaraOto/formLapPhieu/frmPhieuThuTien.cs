using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DAL;
using BLL;

namespace QuanLyGaraOto.formLapPhieu
{
    public partial class frmPhieuThuTien : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields

        DAL.DataService dal;
        BLL.PhieuThuTien bll;

        #endregion

        #region Constructor

        public frmPhieuThuTien()
        {
            InitializeComponent();
            dal = new DataService();
            bll = new BLL.PhieuThuTien();
        }

        #endregion 
 
        #region Methods

        private void cbbTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbTim.Text == "Mã phiếu thu tiền" || cbbTim.Text== "Biển số xe")
            {
                txtTim.Visible = true;
                txtTimDen.Visible = false;
                txtTimTu.Visible = false;
                dtpTimDenNgay.Visible = false;
                dtpTimTuNgay.Visible = false;
                lbDen.Visible = false;
                lbTu.Visible = false;
                btnTim.Visible = false;
            }
            else
            {
                if (cbbTim.Text == "Ngày thu")
                {
                    txtTim.Visible = false;
                    txtTimDen.Visible = false;
                    txtTimTu.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    lbDen.Visible = true;
                    lbTu.Visible = true;
                    btnTim.Visible = true;
                }
                else
                {
                    if (cbbTim.Text == "Số tiền thu")
                    {
                        txtTim.Visible = false;
                        txtTimDen.Visible = true;
                        txtTimTu.Visible = true;
                        dtpTimDenNgay.Visible = false;
                        dtpTimTuNgay.Visible = false;
                        lbDen.Visible = true;
                        lbTu.Visible = true;
                        btnTim.Visible = true;
                    }
                }
            }
        }

        private void frmPhieuThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gARA1DataSet.PHIEUTHUTIENs' table. You can move, or remove it, as needed.
           // this.pHIEUTHUTIENsTableAdapter.Fill(this.gARA1DataSet.PHIEUTHUTIENs);
            // TODO: This line of code loads data into the 'gARA1DataSet.XEs' table. You can move, or remove it, as needed.
            this.xEsTableAdapter.Fill(this.gARA1DataSet.XEs);
            // O tim kiem
            txtTim.Visible = false;
            txtTimDen.Visible = false;
            txtTimTu.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            lbDen.Visible = false;
            lbTu.Visible = false;
            btnTim.Visible = false;
            // load dữ liệu cho DataGridView
            ClearDataGridView();
            dgvTim.DataSource = bll.Select();
            ClearInput();
        }

        private void txtTimTuSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTu.Text.Trim() != "" && txtTimDen.Text.Trim() != "")
            {
                if (double.Parse(txtTimTu.Text) > double.Parse(txtTimDen.Text))
                {
                    txtTimTu.Text = txtTimDen.Text;
                }
            }
        }

        private void txtTimTuSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTimDenSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpTimTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimTuNgay.Value > dtpTimDenNgay.Value)
            {
                MessageBox.Show("Giá trị không hợp logic.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpTimTuNgay.Value = DateTime.Today;
            }
        }

        private void dtpTimDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimTuNgay.Value > dtpTimDenNgay.Value)
            {
                MessageBox.Show("Giá trị không hợp logic.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpTimDenNgay.Value = DateTime.Today;
            }
        }

        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtpNgayThu_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgayThu.Value > dtNow)
            {
                MessageBox.Show("Ngày thu không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgayThu.Value = dtNow;
            }

        }

        private void btnThemCSDL_Click(object sender, EventArgs e)
        {
            if (txtMaPTT.Text.Trim() != "" && cbbBienSoXe.Text.Trim() != "")
            {
                bll.Insert(txtMaPTT.Text, cbbBienSoXe.Text, dtpNgayThu.Value,
                            decimal.Parse(txtSoTienThu.Text));
                frmPhieuThuTien_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào một trong các thông tin cần thiết sau: Mã phiếu thu tiền hoặc biển số xe",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnXoaCSDL_Click(object sender, EventArgs e)
        {
            if (txtMaPTT.Text.Trim() != "")
            {
                bll.Delete(txtMaPTT.Text);
                frmPhieuThuTien_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào mã phiếu thu tiền cần xóa.",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtMaPTT.Focus();
            }
        }

        private void btnSuaCSDL_Click(object sender, EventArgs e)
        {
            if (txtMaPTT.Text.Trim() != "" && cbbBienSoXe.Text.Trim() != "")
            {
                bll.Update(txtMaPTT.Text, cbbBienSoXe.Text, dtpNgayThu.Value,
                            decimal.Parse(txtSoTienThu.Text));
                frmPhieuThuTien_Load(sender, e);
                ClearInput();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập vào một trong các thông tin cần thiết sau: Mã phiếu thu tiền hoặc biển số xe",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void ClearInput()
        {
            txtMaPTT.Text = "";
            txtSoTienThu.Text = "";
            cbbBienSoXe.Text = "";
            dtpNgayThu.Value = DateTime.Today;
        }

        private void dgvTim_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTim.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTim.SelectedRows[0];
                    txtMaPTT.Text = r.Cells[0].Value.ToString();
                    cbbBienSoXe.Text = r.Cells[1].Value.ToString();
                    dtpNgayThu.Value = DateTime.Parse(r.Cells[2].Value.ToString());
                    txtSoTienThu.Text = r.Cells[3].Value.ToString();
                }
            }
            catch { }
        }

        private void ClearDataGridView()
        {
            int rowCount = dgvTim.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgvTim.Rows.Remove(dgvTim.CurrentRow);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            switch (cbbTim.Text)
            {
                case "Số tiền thu":
                    dgvTim.DataSource = bll.SearchSoTienThu(decimal.Parse(txtTimTu.Text),
                                                            decimal.Parse(txtTimDen.Text));
                    break;
                case "Ngày thu":
                    dgvTim.DataSource = bll.SearchNgayThu(dtpTimTuNgay.Value, dtpTimDenNgay.Value);
                    break;
            }
            ClearInput();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView();
            if (txtTim.Text.Trim() == "")
            {
                dgvTim.DataSource = bll.Select();
                ClearInput();
            }
            else
            {
                if (cbbTim.Text == "Biển số xe")
                {
                    dgvTim.DataSource = bll.SearchBienSoXe(txtTim.Text);
                }
                else
                {
                    if (cbbTim.Text == "Mã phiếu thu tiền")
                    {
                        dgvTim.DataSource = bll.SearchMaPhieu(txtTim.Text);
                    }
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            cbbBienSoXe.Text = "";
            dtpNgayThu.Value = DateTime.Today;
            txtSoTienThu.Text = "";
            string str = "";
            // mã bắt đầu cho mã phiếu thu tiền
            if (dgvTim.RowCount - 1 > 1)
            {
                int rowCount = dgvTim.RowCount - 1;
                string temp = dgvTim.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
                char[] arr = temp.ToCharArray();
                int pos = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Char.IsDigit(arr[i]))
                    {
                        pos = i;
                        break;
                    }
                }
                string tempSo = temp.Substring(pos, arr.Length - pos);
                int so = int.Parse(tempSo) + 1;
                str = "PTT" + so.ToString();
            }
            else
            {
                if (dgvTim.RowCount - 1 == 0)
                {
                    str = "PTT1";
                }
                else
                {
                    if (dgvTim.RowCount - 1 == 1)
                    {
                        str = "PTT2";
                    }
                }
            }
            txtMaPTT.Text = str;
        }

        #endregion
    }
}