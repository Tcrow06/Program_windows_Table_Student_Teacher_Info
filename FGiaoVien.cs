using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FGiaoVien()
        {
            InitializeComponent();
        }


        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlString = string.Format("Select*from GiaoVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, conn);
                DataTable dtGiaoVien = new DataTable();
                adapter.Fill(dtGiaoVien);
                gvGvien.DataSource = dtGiaoVien;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string sqlString = string.Format("select*from GiaoVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, conn);
                DataTable dtGiaoVien = new DataTable();
                adapter.Fill(dtGiaoVien);
                gvGvien.DataSource = dtGiaoVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DateTime ns = Convert.ToDateTime(dtpDate.Value);
                string nsinh = ns.ToString("yyyy-MM-dd");
                string sqlString = string.Format("insert dbo.GiaoVien values('{0}','{1}','{2}','{3}')", txtName.Text, txtAddress.Text, txtCmnd.Text, nsinh);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them thanh cong ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai " + ex);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlString = string.Format("Delete from GiaoVien where Cmnd ='{0}'", txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh cong ");
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DateTime ns = Convert.ToDateTime(dtpDate.Value);
                string nsinh = ns.ToString("yyyy-MM-dd");
                string sqlString = string.Format("update GiaoVien set Ten = '{0}', Diachi = '{1}', Nsinh = '{2}' where Cmnd= '{3}'", txtName.Text, txtAddress.Text, nsinh, txtCmnd.Text);
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thanh cong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai " + ex);
            }
            finally
            {
                conn.Close();
                LoadData();
            }
        }

        private void gvGvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvGvien.Rows[gvGvien.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtAddress.Text = gvGvien.Rows[gvGvien.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtCmnd.Text = gvGvien.Rows[gvGvien.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dtpDate.Text = gvGvien.Rows[gvGvien.CurrentCell.RowIndex].Cells[3].Value.ToString();
        }
    }
}
