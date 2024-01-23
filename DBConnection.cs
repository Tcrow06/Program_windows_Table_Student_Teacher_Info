using Microsoft.Data.SqlClient;
using System.Data;

namespace ThucHanh1
{
    public  class DBConnection
    {
        public DBConnection() { }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public void ThucThi(string str)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(str, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai " + ex);
            }

            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadData(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(str, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
            return dt;
        }
    }
}
