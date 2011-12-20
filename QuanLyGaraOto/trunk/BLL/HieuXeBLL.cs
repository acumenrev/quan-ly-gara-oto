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
    public class HieuXeBLL
    {
        #region Fields

        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor
        
        public HieuXeBLL()
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
       /// <param name="hieuXe">Hiệu xe</param>
       /// <param name="ghiChu">Ghi chú</param>
        public void Insert(string hieuXe, string ghiChu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("HieuXe_Insert", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                m_cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
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
        /// <param name="hieuXe">Hiệu xe</param>
        /// <param name="ghiChu">Ghi chú</param>
        public void Update(string hieuXe, string ghiChu)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("HieuXe_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
                m_cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                m_cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
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
        /// Xóa record
        /// </summary>
        /// <param name="hieuXe">Hiệu xe</param>
        public void Delete(string hieuXe)
        {
            try
            {
                // mở kết nối CSDL
                dal.OpenConnection(m_conn);
                // thiết lập thông số cho SqlCommand
                m_cmd = new SqlCommand("HieuXe_Delete", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // các đối số 
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
        public DataTable Select()
        {
            // truy vấn tới bảng dữ liệu
            m_da = dal.CreateAdapter("HieuXe_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        public DataTable Search(string hieuXe)
        {
            DataTable dt = new DataTable();
            //using (SqlConnection conn = m_conn)
            //{
            //    conn.Open();
            //    // thiêt lập thông số SqlCommand
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = conn;
            //        cmd.CommandText = "HieuXe_Search";
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.Add("@HieuXe", SqlDbType.Char).Value = hieuXe;
                    
            //        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            //        {
            //            da.Fill(dt);
            //        }
            //    }
            //}
            dal.OpenConnection(m_conn);
            m_cmd = new SqlCommand("HieuXe_Search", m_conn);
            m_cmd.CommandType = CommandType.StoredProcedure;

            m_cmd.Parameters.Add("@HieuXe", SqlDbType.VarChar).Value = hieuXe;
            m_da = new SqlDataAdapter(m_cmd);
            m_da.Fill(dt);
            return dt;
        }

        #endregion
    }
}
