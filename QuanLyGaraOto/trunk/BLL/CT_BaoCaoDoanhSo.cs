using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class CT_BaoCaoDoanhSo
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public CT_BaoCaoDoanhSo()
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
        /// <param name="maBC">Mã báo cáo</param>
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="soLuotSua">Số lượt sửa</param>
        /// <param name="thanhTien">Thành tiền</param>
        /// <param name="tiLe"></param>
        public void Insert(string maBC, string hieuXe, int soLuotSua, 
                            decimal thanhTien, float tiLe)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_BaoCaoDoanhSo_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                m_cmd.Parameters.Add("@SoLuotSua", SqlDbType.Int).Value = soLuotSua;
                m_cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = thanhTien;
                m_cmd.Parameters.Add("@TiLe", SqlDbType.Real).Value = tiLe;
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
        /// Cập nhật record
        /// </summary>
        /// <param name="maBC">Mã báo cáo</param>
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="soLuotSua">Số lượt sửa</param>
        /// <param name="thanhTien">Thành tiền</param>
        public void Update(string maBC, string hieuXe, int soLuotSua,
                            decimal thanhTien, float tiLe)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_BaoCaoDoanhSo_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                m_cmd.Parameters.Add("@SoLuotSua", SqlDbType.Int).Value = soLuotSua;
                m_cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = thanhTien;
                m_cmd.Parameters.Add("@TiLe", SqlDbType.Real).Value = tiLe;
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
        /// Xóa record trong bảng
        /// </summary>
        /// <param name="maBC">Mã báo cáo</param>
        /// <param name="hieuXe">Hiệu xe</param>
        public void Delete(string maBC, string hieuXe)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("CT_BaoCaoDoanhSo_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
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
        public DataTable Select(string maBC)
        {
            DataTable dt = new DataTable();
            dal.OpenConnection(m_conn);
            // thiết lập thông số cho SqlCommand
            m_cmd = new SqlCommand("CT_BaoCaoDoanhSo_Select", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@MaBC", SqlDbType.Char).Value = maBC;

            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);

            return dt;
        }
        #endregion
    }
}
