using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;


namespace BLL
{
    public class XeBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public XeBLL()
        {
            dal = new DataService();
            m_dt = new DataTable();
            m_cmd = new SqlCommand();
            m_da = new SqlDataAdapter();
            m_conn = dal.GetConnect();
        }
        
        #endregion

        #region Methods

       /// <summary>
       /// Thêm record
       /// </summary>
       /// <param name="bienSoXe">Biển số xe</param>
       /// <param name="tenChuXe">Tên chủ xe</param>
       /// <param name="hieuXe">Hiệu xe</param>
       /// <param name="diaChi">Địa chỉ</param>
       /// <param name="ngayTiepNhan">Ngày tiếp nhận</param>
       /// <param name="email">Email</param>
       /// <param name="tienNo">Tiền nợ</param>
        public void Insert(string bienSoXe, string tenChuXe, string hieuXe,
                            string diaChi, DateTime ngayTiepNhan,
                            string email, decimal tienNo, int dienThoai)
        {
            try
            {
                // kiểm tra số xe đã nhận trong ngày đã 
                // vượt qua giới hạn chưa
                if (KiemTraSoXeSuaTrongNgay(ngayTiepNhan) == false)
                {
                    if (bienSoXe.Trim() != "" && tenChuXe.Trim() != "" &&
                        hieuXe.Trim() != "" && diaChi.Trim() != "" && email.Trim() != "")
                    {
                        // mở kết nối CSDL
                        dal.OpenConnection(m_conn);
                        // thiết lập thông số cho SqlCommand
                        m_cmd = new SqlCommand("Xe_Insert", m_conn);
                        m_cmd.CommandType = CommandType.StoredProcedure;
                        // các đối số 
                        m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                        m_cmd.Parameters.Add("@TenChuXe", SqlDbType.NVarChar).Value = tenChuXe;
                        m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                        m_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                        m_cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.DateTime).Value = ngayTiepNhan;
                        m_cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                        m_cmd.Parameters.Add("@TienNo", SqlDbType.Decimal).Value = tienNo;
                        m_cmd.Parameters.Add("@DienThoai", SqlDbType.Int).Value = dienThoai;
                        // thực thi câu truy vấn
                        m_cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: biến số xe, tên chủ xe, hiệu xe, địa chỉ, email.\nXin xem lại",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã vượt quá số xe quy định được nhận trong ngày.\nBạn không thể nhập thêm được nữa", 
                        "Cảnh báo", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Biển số xe bạn vừa nhập hiện đã có trong\n" +
                                "cơ sở dữ liệu.\nXin hãy xem lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        /// <param name="bienSoXe">Biển số xe</param>
        /// <param name="tenChuXe">Tên chủ xe</param>
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="diaChi">Địa chỉ</param>
        /// <param name="ngayTiepNhan">Ngày tiếp nhận</param>
        /// <param name="email">Email</param>
        /// <param name="tienNo">Tiền nợ</param>
        public void Update(string bienSoXe, string tenChuXe, string hieuXe,
                            string diaChi, DateTime ngayTiepNhan,
                            string email, decimal tienNo, int dienThoai)
        {
            try
            {
                if (bienSoXe.Trim() != "" && tenChuXe.Trim() != "" &&
                    hieuXe.Trim() != "" && diaChi.Trim() != "" && email.Trim() != "")
                {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("Xe_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                m_cmd.Parameters.Add("@TenChuXe", SqlDbType.NVarChar).Value = tenChuXe;
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                m_cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                m_cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.DateTime).Value = ngayTiepNhan;
                m_cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                m_cmd.Parameters.Add("@TienNo", SqlDbType.Decimal).Value = tienNo;
                m_cmd.Parameters.Add("@DienThoai", SqlDbType.Int).Value = dienThoai;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: biến số xe, tên chủ xe, hiệu xe, địa chỉ, email.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể cập nhật lại biển số xe.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);

            }
        }

        /// <summary>
        /// Xóa record
        /// </summary>
        /// <param name="bienSoXe">Biển số xe</param>
        public void Delete(string bienSoXe)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("Xe_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Nội dung bạn đang xóa hiện đang có trong một hóa đơn hoặc báo cáo nên không thể xóa được.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dt.Dispose();
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);

            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            dal.OpenConnection(m_conn);
            m_da.Dispose();
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("Xe_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;  
        }

        /// <summary>
        /// Tìm theo biển số xe
        /// </summary>
        /// <param name="noiDungTimKiem">Biến số xe cần tìm</param>
        /// <returns></returns>
        public DataTable SearchBienSoXe(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("Xe_SearchBienSoXe", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm theo tên chủ xe
        /// </summary>
        /// <param name="noiDungTimKiem">Tên chủ xe cần tìm</param>
        /// <returns></returns>
        public DataTable SearchTenChuXe(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("Xe_SearchTenChuXe", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm theo hiệu xe
        /// </summary>
        /// <param name="noiDungTimKiem">Hiệu xe cần tìm </param>
        /// <returns></returns>
        public DataTable SearchHieuXe(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("Xe_SearchHieuXe", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm theo địa chỉ
        /// </summary>
        /// <param name="noiDungTimKiem">Địa chỉ cần tìm</param>
        /// <returns></returns>
        public DataTable SearchDiaChi(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("Xe_SearchDiaChi", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm theo ngày tiếp nhận
        /// </summary>
        /// <param name="tuNgay">Tìm từ ngày</param>
        /// <param name="denNgay">Tìm đến ngày</param>
        /// <returns></returns>
        public DataTable SearchNgayTiepNhan(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("Xe_SearchNgayTiepNhan", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@TuNgay", SqlDbType.Char).Value = tuNgay.ToString("MM/dd/yyyy");
            m_cmd.Parameters.Add("@DenNgay", SqlDbType.Char).Value = denNgay.ToString("MM/dd/yyyy");
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        private bool KiemTraSoXeSuaTrongNgay(DateTime ngay)
        {
            bool daVuotQua = false;
            BLL.ThamSoBLL bll_thamSo = new ThamSoBLL();
            int soXeToiDa = int.Parse(bll_thamSo.Select().Rows[0]["SoXeSuaChuaToiDaTrongNgay"].ToString());
            int soXeDaNhanTrongNgay = SearchNgayTiepNhan(ngay, ngay).Rows.Count - 1;
            if (soXeDaNhanTrongNgay > soXeToiDa)
            {
                daVuotQua = true;
            }
            else
            {
                daVuotQua = false;
            }
            return daVuotQua;
        }
        #endregion
    }
}
