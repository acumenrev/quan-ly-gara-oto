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
    public class PhieuNhapVTPT
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;
        
        #endregion

        #region Constructor
        
        public PhieuNhapVTPT()
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
        /// <param name="maPN">Mã phiếu nhập</param>
        /// <param name="ngayNhap">Ngày nhập</param>
        public void Insert(string maPN, DateTime ngayNhap)
        {
            try
            {
                if (maPN.Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("PhieuNhapVTPT_Insert", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                    m_cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = ngayNhap;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã phiếu nhập.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Mã phiếu nhập vật tư phụ tùng bạn vừa nhập hiện đã có trong\n" +
                                "cơ sở dữ liệu.\nXin hãy xem lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Cập nhật record
        /// </summary>
        /// <param name="maPN">Mã phiếu nhập</param>
        /// <param name="ngayNhap">Ngày nhập</param>
        public void Update(string maPN, DateTime ngayNhap)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuNhapVTPT_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                m_cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = ngayNhap;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể thay dổi mã phiếu nhập.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Xóa record
        /// </summary>
        /// <param name="maPN">Mã phiếu nhập</param>
        public void Delete(string maPN)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuNhapVTPT_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                // đóng kết nối và xóa dữ liệu tạm
                dal.CloseConnection(m_conn);
                m_dt.Dispose();
            }
        }

        /// <summary>
        /// Truy vấn các record
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("PhieuNhapVTPT_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm mã phiếu nhập
        /// </summary>
        /// <param name="noiDungTimKiem">Mã phiếu nhập</param>
        /// <returns></returns>
        public DataTable SearchMaPhieuNhap(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuNhapVTPT_SearchMaPhieuNhap", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.NVarChar).Value = noiDungTimKiem;
            // thực thi câu truy vấn
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm kiếm ngày nhập
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchNgayNhap(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuNhapVTPT_SearchNgayNhap", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Char).Value = tu.ToString("MM/dd/yyyy");
            m_cmd.Parameters.Add("@Den", SqlDbType.Char).Value = den.ToString("MM/dd/yyyy");
            // thực thi câu truy vấn
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
