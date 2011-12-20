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
    public class PhieuThuTien
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public PhieuThuTien()
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
       /// Chèn thêm record
       /// </summary>
       /// <param name="maPTT">Mã phiếu thu tiền</param>
       /// <param name="bienSoXe">Biển số xe</param>
       /// <param name="ngayThu">Ngày thu</param>
       /// <param name="soTienThu">Số tiền thu</param>
        public void Insert(string maPTT,string bienSoXe,DateTime ngayThu,decimal soTienThu)
        {
            try
            {
                if (maPTT.Trim() != "" && bienSoXe.Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("PhieuThuTien_Insert", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@MaPTT", SqlDbType.Char).Value = maPTT;
                    m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                    m_cmd.Parameters.Add("@NgayThu", SqlDbType.DateTime).Value = ngayThu;
                    m_cmd.Parameters.Add("@SoTienThu", SqlDbType.Decimal).Value = soTienThu;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã phiếu thu tiền, biển số xe.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Mã phiếu thu tiền bạn vừa nhập hiện đã có trong\n" +
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
        /// <param name="maPTT">Mã phiếu thu tiền</param>
        /// <param name="bienSoXe">Biển số xe</param>
        /// <param name="ngayThu">Ngày thu</param>
        /// <param name="soTienThu">Số tiền thu</param>
        public void Update(string maPTT, string bienSoXe, DateTime ngayThu, decimal soTienThu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuThuTien_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPTT", SqlDbType.Char).Value = maPTT;
                m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                m_cmd.Parameters.Add("@NgayThu", SqlDbType.DateTime).Value = ngayThu;
                m_cmd.Parameters.Add("@SoTienThu", SqlDbType.Decimal).Value = soTienThu;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể thay dổi mã phiếu thu tiền.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// <param name="maPTT">Mã phiếu thu tiền</param>
        public void Delete(string maPTT)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuThuTien_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPTT", SqlDbType.Char).Value = maPTT;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
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
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("PhieuThuTien_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm mã phiếu
        /// </summary>
        /// <param name="noiDungTimKiem">Mã phiếu</param>
        /// <returns></returns>
        public DataTable SearchMaPhieu(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("PhieuThuTien_SearchMaPhieu", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            // thực thi câu lệnh
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm biển số xe
        /// </summary>
        /// <param name="noiDungTimKiem">Biển số xe</param>
        /// <returns></returns>
        public DataTable SearchBienSoXe(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("PhieuThuTien_SearchBienSoXe", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            // thực thi câu lệnh
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm số tiền thu
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchSoTienThu(decimal tu, decimal den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("PhieuThuTien_SearchSoTienThu", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Decimal).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.Decimal).Value = den;
            // thực thi câu lệnh
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm ngày thu
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchNgayThu(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("PhieuThuTien_SearchNgayLapPhieu", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Char).Value = tu.ToString("MM/dd/yyyy");
            m_cmd.Parameters.Add("@Den", SqlDbType.Char).Value = den.ToString("MM/dd/yyyy");
            // thực thi câu lệnh
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
