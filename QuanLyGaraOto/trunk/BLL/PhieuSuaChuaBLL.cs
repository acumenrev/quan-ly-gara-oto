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
    public class PhieuSuaChuaBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public PhieuSuaChuaBLL()
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
       /// <param name="maPSC">Mã phiếu sửa chữa</param>
       /// <param name="bienSoXe">Biển số xe</param>
       /// <param name="ngaySuaChua">Ngày sửa chữa</param>
       /// <param name="tongTien">Tổng tiên</param>
        public void Insert(string maPSC, string bienSoXe, DateTime ngaySuaChua, decimal tongTien)
        {
            try
            {
                if (maPSC.Trim() != "" && bienSoXe.Trim() != "" && tongTien.ToString().Trim() != "")
                {
                    // mở kết nối CSDL
                    dal.OpenConnection(m_conn);
                    // thiết lập thông số cho SqlCommand
                    m_cmd = new SqlCommand("PhieuSuaChua_Insert", m_conn);
                    m_cmd.CommandType = CommandType.StoredProcedure;
                    // các đối số 
                    m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
                    m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                    m_cmd.Parameters.Add("@NgaySuaChua", SqlDbType.DateTime).Value = ngaySuaChua;
                    m_cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;
                    // thực thi câu truy vấn
                    m_cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập một trong các thông tin cần thiết sau: mã phiếu sửa chữa, biển số xe, tổng tiền.\nXin xem lại",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Mã phiếu sửa chữa bạn vừa nhập hiện đã có trong\n" +
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
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        /// <param name="bienSoXe">Biển số xe</param>
        /// <param name="ngaySuaChua">Ngày sửa chữa</param>
        /// <param name="tongTien">Tổng tiên</param>
        public void Update(string maPSC, string bienSoXe, DateTime ngaySuaChua, decimal tongTien)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuSuaChua_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
                m_cmd.Parameters.Add("@BienSoXe", SqlDbType.Char).Value = bienSoXe;
                m_cmd.Parameters.Add("@NgaySuaChua", SqlDbType.DateTime).Value = ngaySuaChua;
                m_cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = tongTien;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Bạn không thể thay dổi mã phiếu sửa chữa.\nNếu muốn thì hãy xóa đi dữ liệu này và tạo lại mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        /// <param name="maPSC">Mã phiếu sửa chữa</param>
        public void Delete(string maPSC)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("PhieuSuaChua_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaPSC", SqlDbType.Char).Value = maPSC;
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
            m_da = dal.CreateAdapter("PhieuSuaChua_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        /// <summary>
        /// Tìm mã phiếu sửa chữa
        /// </summary>
        /// <param name="noiDungTimKiem"></param>
        /// <returns></returns>
        public DataTable SearchMaPSC(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuSuaChua_SearchMaPSC", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm biển số xe
        /// </summary>
        /// <param name="noiDungTimKiem"></param>
        /// <returns></returns>
        public DataTable SearchBienSoXe(string noiDungTimKiem)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuSuaChua_SearchBienSoXe", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@NoiDungTimKiem", SqlDbType.VarChar).Value = noiDungTimKiem;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Tìm ngày sửa chữa
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchNgaySuaChua(DateTime tu, DateTime den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuSuaChua_SearchNgaySuaChua", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;
            // các đối số
            m_cmd.Parameters.Add("@Tu", SqlDbType.Char).Value = tu.ToString("MM/dd/yyyy");
            m_cmd.Parameters.Add("@Den", SqlDbType.Char).Value = den.ToString("MM/dd/yyyy");
            // thực thi câu truy vấn
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Tìm tổng tiền
        /// </summary>
        /// <param name="tu"></param>
        /// <param name="den"></param>
        /// <returns></returns>
        public DataTable SearchTongTien(decimal tu, decimal den)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số SqlCommand
            m_cmd = new SqlCommand("PhieuSuaChua_SearchTongTien", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@Tu", SqlDbType.Decimal).Value = tu;
            m_cmd.Parameters.Add("@Den", SqlDbType.Decimal).Value = den;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }

        #endregion
    }
}
