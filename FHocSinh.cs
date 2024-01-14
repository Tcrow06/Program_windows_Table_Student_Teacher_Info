using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
namespace ThucHanh1
{
    public partial class FHocSinh : Form
    {
        public FHocSinh()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);


        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT*FROM HocSinh");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                gvHsinh.DataSource = dtSinhVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }

            finally { conn.Close(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ket noi 
                conn.Open();
                //string.sqlStr = string.Format("insert into HocSinh(Ten")
                string sqlStr = string.Format("insert into HocSinh(Ten, Diachi, Cmnd, Nsinh) Values('{0}', '{1}', '{2}', {3})", txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDate);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them thanh cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai " + ex);
            }

            finally { conn.Close(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            string sqlStr = string.Format("delete from HocSinh where Cmnd = {0}", txtCmnd.Text);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xoa that bai " + ex);
            }
            finally { conn.Close(); }
        }

        private void sua_hs_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DateTime ns = Convert.ToDateTime(dtpDate.Value);
                string nsinh = ns.ToString("yyyy-MM-dd");
                string sqlString = string.Format("update HocSinh set Ten='{0}', Diachi='{1}',Nsinh='{2}' where Cmnd='{3}'", txtName.Text, txtAddress.Text, nsinh, txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }

            }catch(Exception ex) {
                MessageBox.Show("Sua that bai " + ex);
            }
            finally { conn.Close(); }
        }
    }


}
