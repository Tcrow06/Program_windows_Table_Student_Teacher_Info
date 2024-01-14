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
        private void LoadData()
        {
            try
            {
                conn.Open();
                string sqlString = string.Format("Select*from HocSinh");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                gvHsinh.DataSource = dtSinhVien;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ket noi 
                conn.Open();
    
                DateTime ns = Convert.ToDateTime(dtpDate.Value);
                string nsinh = ns.ToString("yyyy-MM-dd");
                string sqlStr = string.Format("insert into HocSinh(Ten, Diachi, Cmnd, Nsinh) Values('{0}', '{1}', '{2}', '{3}')", txtName.Text, txtAddress.Text, txtCmnd.Text, nsinh);
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

            finally
            {
                conn.Close();
                LoadData();

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("delete from HocSinh where Cmnd = '{0}'", txtCmnd.Text);
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
            finally
            {
                conn.Close();
                LoadData();
            }
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
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sua that bai " + ex);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvHsinh.Rows[gvHsinh.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = gvHsinh.Rows[gvHsinh.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtCmnd.Text = gvHsinh.Rows[gvHsinh.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dtpDate.Text = gvHsinh.Rows[gvHsinh.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }

        private void btnGvien_Click(object sender, EventArgs e)
        {
            FGiaoVien? fgv = new FGiaoVien();
            this.Hide();
            fgv.ShowDialog();
            fgv = null;
            this.Show();

        }
    }


}
