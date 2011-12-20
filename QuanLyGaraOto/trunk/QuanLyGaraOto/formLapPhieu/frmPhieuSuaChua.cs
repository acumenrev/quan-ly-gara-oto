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
    public partial class frmPhieuSuaChua : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        DAL.DataService dal;
        BLL.PhieuSuaChuaBLL bll_chung;
        BLL.CT_PhieuSuaChuaBLL bll_rieng;
        #endregion

        #region Constructor

        public frmPhieuSuaChua()
        {
            InitializeComponent();
            dal = new DataService();
            bll_chung = new PhieuSuaChuaBLL();
            bll_rieng = new CT_PhieuSuaChuaBLL();
        }

        #endregion

        #region Methods

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

        private void txtTimTuSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTimDenSoTien.Text.Trim() != "" && txtTimTuSoTien.Text.Trim() != "")
            {
                if (double.Parse(txtTimTuSoTien.Text) > double.Parse(txtTimDenSoTien.Text))
                {
                    txtTimTuSoTien.Text = txtTimDenSoTien.Text;
                }
            }
        }


        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTimTTChung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTTChung.Text == "Mã phiếu sửa chữa" || cbbTimTTChung.Text == "Biển số xe")
            {
                lbTu.Visible = false;
                lbDen.Visible = false;
                txtTimTuSoTien.Visible = false;
                txtTimDenSoTien.Visible = false;
                dtpTimDenNgay.Visible = false;
                dtpTimTuNgay.Visible = false;
                btnTim.Visible = false;
                txtTimTTChung.Visible = true;
            }
            else
            {
                if (cbbTimTTChung.Text == "Ngày sửa xe")
                {
                    lbTu.Visible = true;
                    lbDen.Visible = true;
                    txtTimTuSoTien.Visible = false;
                    txtTimDenSoTien.Visible = false;
                    dtpTimDenNgay.Visible = true;
                    dtpTimTuNgay.Visible = true;
                    btnTim.Visible = true;
                    txtTimTTChung.Visible = false;
                }
                else
                {
                    if (cbbTimTTChung.Text == "Tổng tiền")
                    {
                        lbTu.Visible = true;
                        lbDen.Visible = true;
                        txtTimTuSoTien.Visible = true;
                        txtTimDenSoTien.Visible = true;
                        dtpTimDenNgay.Visible = false;
                        dtpTimTuNgay.Visible = false;
                        btnTim.Visible = true;
                        txtTimTTChung.Visible = false;
                    }
                }
            }
        }

        private void frmPhieuSuaChua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gARA1DataSet.VATTUPHUTUNGs' table. You can move, or remove it, as needed.
            this.vATTUPHUTUNGsTableAdapter.Fill(this.gARA1DataSet.VATTUPHUTUNGs);
            // TODO: This line of code loads data into the 'gARA1DataSet.CT_PHIEUSUACHUA' table. You can move, or remove it, as needed.
            this.cT_PHIEUSUACHUATableAdapter.Fill(this.gARA1DataSet.CT_PHIEUSUACHUA);
            // TODO: This line of code loads data into the 'gARA1DataSet.TIENCONGs' table. You can move, or remove it, as needed.
            this.tIENCONGsTableAdapter.Fill(this.gARA1DataSet.TIENCONGs);
            // TODO: This line of code loads data into the 'gARA1DataSet.XEs' table. You can move, or remove it, as needed.
            this.xEsTableAdapter.Fill(this.gARA1DataSet.XEs);
            // o tim kiem chung
            lbTu.Visible = false;
            lbDen.Visible = false;
            txtTimTuSoTien.Visible = false;
            txtTimDenSoTien.Visible = false;
            dtpTimDenNgay.Visible = false;
            dtpTimTuNgay.Visible = false;
            btnTim.Visible = false;
            txtTimTTChung.Visible = false;
            txtTimTTRieng.Visible = false;
            cbbSoLuong.Text = "";
            ClearDataGridView(dgvTimTTChung);
            ClearDataGridView(dgvTimTTRieng);
            dgvTimTTChung.DataSource = bll_chung.Select();
            dgvTimTTRieng.DataSource = bll_rieng.Select(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void dtpNgaySuaChua_ValueChanged(object sender, EventArgs e)
        {
            DateTime dtNow = DateTime.Now;
            if (dtpNgaySuaChua.Value > dtNow)
            {
                MessageBox.Show("Ngày thu không thể lớn hơn ngày hiện tại.\nXin xem lại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpNgaySuaChua.Value = dtNow;
            }
        }

        private void txtTimDenSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia_KeyPress(sender, e);
        }

        private void txtTimTuSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDonGia_KeyPress(sender, e);
        }

        private void dgvTimTTChung_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTimTTChung.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTimTTChung.SelectedRows[0];
                    txtMaPSC.Text = r.Cells[0].Value.ToString();
                    cbbBienSoXe.Text = r.Cells[1].Value.ToString();
                    dtpNgaySuaChua.Value = DateTime.Parse(r.Cells[2].Value.ToString());
                    txtTongTien.Text = r.Cells[3].Value.ToString();
                    dgvTimTTRieng.DataSource = bll_rieng.Select(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch { }
        }

        private void dgvTimTTRieng_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTimTTRieng.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dgvTimTTRieng.SelectedRows[0];
                    cbbNoiDung.Text = r.Cells[0].Value.ToString();
                    cbbTienCong.Text = r.Cells[1].Value.ToString();
                    cbbMaVTPT.Text = r.Cells[2].Value.ToString();
                    cbbSoLuong.Text = r.Cells[3].Value.ToString();
                    cbbDonGia.Text = r.Cells[4].Value.ToString();
                    txtThanhTien.Text = r.Cells[5].Value.ToString();
                }
            }
            catch
            { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTimTTRieng_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimTTRieng.Text != "")
            {
                txtTimTTRieng.Visible = true;
            }
        }


        private void btnThemTTChung_Click(object sender, EventArgs e)
        {
            bll_chung.Insert(txtMaPSC.Text, cbbBienSoXe.Text, dtpNgaySuaChua.Value,
                            decimal.Parse(txtTongTien.Text));
            ClearGeneralInputs();
            ClearDataGridView(dgvTimTTChung);
            dgvTimTTChung.DataSource = bll_chung.Select();
        }

        private void btnSuaTTChung_Click(object sender, EventArgs e)
        {
            bll_chung.Update(txtMaPSC.Text, cbbBienSoXe.Text, dtpNgaySuaChua.Value,
                decimal.Parse(txtTongTien.Text));
            ClearGeneralInputs();
            ClearDataGridView(dgvTimTTChung);
            dgvTimTTChung.DataSource = bll_chung.Select();
        }

        private void btnXoaTTChung_Click(object sender, EventArgs e)
        {
            string str = "Bạn có chắc muốn xóa báo cáo này không ?";
            DialogResult msg = MessageBox.Show(str, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                //// Xóa các phần tử trong báo cáo
                //for (int i = 0; i < dgvTimTTRieng.Rows.Count - 1; i++)
                //{
                //    ClearDataGridView(dgvTimTTRieng);
                //    bll_rieng.Delete(dgvTimTTChung.CurrentRow.Cells[0].Value.ToString(),
                //                     dgvTimTTRieng.CurrentRow.Cells[0].Value.ToString());
                //}
                // Xóa báo cáo chung
                bll_chung.Delete(txtMaPSC.Text);
                ClearGeneralInputs();
                ClearDataGridView(dgvTimTTChung);
                dgvTimTTChung.DataSource = bll_chung.Select();
            }
        }

        private void btnThemTTRieng_Click(object sender, EventArgs e)
        {
            if (cbbSoLuong.Text == "")
            {
                MessageBox.Show("Số lượng chưa được cập nhật", 
                                "Cảnh báo",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            }
            else
            {
                decimal thanhTien = 0;
                thanhTien = decimal.Parse(cbbTienCong.Text) + decimal.Parse(cbbDonGia.Text) * decimal.Parse(cbbSoLuong.Text);
                bll_rieng.Insert(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString(),
                                cbbNoiDung.Text,
                                cbbMaVTPT.Text,
                                decimal.Parse(cbbTienCong.Text),
                                int.Parse(cbbSoLuong.Text),
                                decimal.Parse(cbbDonGia.Text),
                                thanhTien);
                ClearDataGridView(dgvTimTTRieng);
                dgvTimTTRieng.DataSource = bll_rieng.Select(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString());
                ClearDetailInputs();
                TinhTongThanhTien();
            }
        }

        private void btnSuaTTRieng_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSoLuong.Text != "")
                {
                    decimal thanhTien = decimal.Parse(cbbSoLuong.Text) * decimal.Parse(cbbDonGia.Text) + decimal.Parse(cbbTienCong.Text);
                    ClearDataGridView(dgvTimTTRieng);
                    bll_rieng.Update(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString(),
                                     cbbNoiDung.Text,
                                     cbbMaVTPT.Text,
                                     decimal.Parse(cbbTienCong.Text),
                                     int.Parse(cbbSoLuong.Text),
                                     decimal.Parse(cbbDonGia.Text),
                                     thanhTien);
                    dgvTimTTRieng.DataSource = bll_rieng.Select(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString());
                    ClearDetailInputs();
                    TinhTongThanhTien();
                }
                else
                {
                    MessageBox.Show("Số lượng chưa được cập nhật", "Cảnh báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTTRieng_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dgvTimTTRieng);
            bll_rieng.Delete(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString(),
                               cbbNoiDung.Text);
            dgvTimTTRieng.DataSource = bll_rieng.Select(dgvTimTTChung.SelectedRows[0].Cells[0].Value.ToString());
            ClearDetailInputs();
            TinhTongThanhTien();
        }

        /// <summary>
        /// Tính tổng thành tiền
        /// </summary>
        private void TinhTongThanhTien()
        {
            decimal tongThanhTien = 0;
            for (int i = 0; i < dgvTimTTRieng.RowCount - 1; i++)
            {
                decimal thanhTien = decimal.Parse(dgvTimTTRieng.Rows[i].Cells[5].Value.ToString());
                tongThanhTien += thanhTien;
            }
            txtTongTien.Text = tongThanhTien.ToString();
        }


        private void ClearGeneralInputs()
        {
            txtMaPSC.Text = "";
            cbbBienSoXe.Text = "";
            dtpNgaySuaChua.Value = DateTime.Today;
            txtTongTien.Text = "";
        }

        private void ClearDetailInputs()
        {
            cbbNoiDung.Text = "";
            cbbDonGia.Text = "";
            cbbTienCong.Text = "";
            cbbMaVTPT.Text = "";
            cbbSoLuong.Text = "";
            txtThanhTien.Text = "";
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            int rowCount = dgv.RowCount - 1;
            for (int i = 0; i < rowCount; i++)
            {
                dgv.Rows.Remove(dgv.CurrentRow);
            }
        }

        private void cbbMaVTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSoLuong.Items.Clear();
            BLL.VTPTBLL bll = new VTPTBLL();
            DataTable dt = bll.Select_SoLuong(cbbMaVTPT.Text);
            if (dt.Rows.Count > 0)
            {
                int soLuong = int.Parse(dt.Rows[0]["SoLuongTon"].ToString());
                for (int i = 1; i < soLuong + 1; i++)
                {
                    cbbSoLuong.Items.Add(i);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ClearDataGridView(dgvTimTTChung);
            switch(cbbTimTTChung.Text)
            {
                case "Ngày sửa xe":
                    dgvTimTTChung.DataSource = bll_chung.SearchNgaySuaChua(dtpTimTuNgay.Value, dtpTimDenNgay.Value);
                    break;
                case "Tổng tiền":
                    dgvTimTTChung.DataSource = bll_chung.SearchTongTien(decimal.Parse(txtTimTuSoTien.Text), decimal.Parse(txtTimDenSoTien.Text));
                    break;
            }
            ClearGeneralInputs();
        }

        private void txtTimTTChung_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView(dgvTimTTChung);
            if (txtTimTTChung.Text.Trim() == "")
            {
                dgvTimTTChung.DataSource = bll_chung.Select();
                ClearGeneralInputs();
            }
            else
            {
                switch(cbbTimTTChung.Text)
                {
                    case "Mã phiếu sửa chữa":
                        dgvTimTTChung.DataSource = bll_chung.SearchMaPSC(txtTimTTChung.Text);
                        break;
                    case "Biển số xe":
                        dgvTimTTChung.DataSource = bll_chung.SearchBienSoXe(txtTimTTChung.Text);
                        break;
                }
            }
        }

        private void txtTimTTRieng_TextChanged(object sender, EventArgs e)
        {
            ClearDataGridView(dgvTimTTRieng);
            if (txtTimTTRieng.Text.Trim() == "")
            {
                dgvTimTTChung.DataSource = bll_rieng.Select(txtMaPSC.Text);
                ClearDetailInputs();
            }
            else
            {
                switch (cbbTimTTRieng.Text)
                {
                    case "Mã VTPT":
                        dgvTimTTRieng.DataSource = bll_rieng.SearchMaVTPT(txtTimTTRieng.Text,
                                                                            txtMaPSC.Text);
                        break;
                    case "Nội dung":
                        dgvTimTTRieng.DataSource = bll_rieng.SearchNoiDung(txtTimTTRieng.Text,
                                                                            txtMaPSC.Text);
                        break;
                }
            }
        }

        private void cbbNoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSoLuong.Text.Trim() != "")
            {
                decimal thanhTien = decimal.Parse(cbbSoLuong.Text) * decimal.Parse(cbbDonGia.Text) +
                                    decimal.Parse(cbbTienCong.Text);
                txtThanhTien.Text = thanhTien.ToString();
            }
        }

        private void cbbTienCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNoiDung_SelectedIndexChanged(sender, e);
        }


        private void cbbSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbNoiDung_SelectedIndexChanged(sender, e);
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaPSC.Text = "";
            cbbBienSoXe.Text = "";
            dtpNgaySuaChua.Value = DateTime.Today;
            txtTongTien.Text = "";

            string str = "";
            // mã bắt đầu cho mã phiếu thu tiền
            if (dgvTimTTChung.RowCount - 1 > 1)
            {
                int rowCount = dgvTimTTChung.RowCount - 1;
                string temp = dgvTimTTChung.Rows[rowCount - 1].Cells[0].Value.ToString().Trim();
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
                str = "PSC" + so.ToString();
            }
            else
            {
                if (dgvTimTTChung.RowCount - 1 == 0)
                {
                    str = "PSC1";
                }
                else
                {
                    if (dgvTimTTChung.RowCount - 1 == 1)
                    {
                        str = "PSC2";
                    }
                }
            }
            txtMaPSC.Text = str;
        }

        #endregion
    }
}