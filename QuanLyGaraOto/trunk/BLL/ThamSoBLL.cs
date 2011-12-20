using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Xml;
using System.Data;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class ThamSoBLL
    {
        #region Fields


        DAL.DataService dal;
        private SqlDataAdapter m_da;
        private SqlCommand m_cmd;
        private DataTable m_dt;
        private SqlConnection m_conn;

        #endregion

        #region Constructor

        public ThamSoBLL()
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
        /// Cập nhật record
        /// </summary>
        /// <param name="soXeSuaChuaToiDaTrongNgay">Số xe sữa chữa tối đa trong ngày</param>
        public void Update(int soXeSuaChuaToiDaTrongNgay)
        {
            try
            {
                // Mở kết nối
                dal.OpenConnection(m_conn);
                // Thiết lập các thông số
                m_cmd = new SqlCommand("ThamSo_Update", m_conn);
                m_cmd.CommandType = CommandType.StoredProcedure;
                // đối số
                m_cmd.Parameters.Add("@SoXeSuaChuaToiDaTrongNgay", SqlDbType.Int).Value = soXeSuaChuaToiDaTrongNgay;
                // thực thi câu truy vấn
                m_cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
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
            m_da = dal.CreateAdapter("ThamSo_Select", m_conn);
            m_da.Fill(m_dt);
            return m_dt;
        }

        #endregion
    }
}
