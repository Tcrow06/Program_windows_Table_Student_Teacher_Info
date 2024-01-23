
namespace ThucHanh1
{
    public partial class FHocSinh : Form
    {
        public FHocSinh()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            HocSinhDAO hsd = new HocSinhDAO();
            gvHsinh.DataSource = hsd.LoadData();
        }
        //Them
        private void button1_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDate.Value);
            HocSinhDAO hsd = new HocSinhDAO();
            hsd.Them(hs);
            LoadData();
        }
        //Xoa
        private void button2_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.Cmnd = txtCmnd.Text;
            HocSinhDAO hsd = new HocSinhDAO();
            hsd.Xoa(hs);
            LoadData();
        }
        //Sua
        private void sua_hs_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDate.Value);
            HocSinhDAO hsd = new HocSinhDAO();
            hsd.Sua(hs);
            LoadData();
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvHsinh?.Rows[gvHsinh.CurrentCell.RowIndex]?.Cells[0]?.Value?.ToString()?.Trim();
            txtAddress.Text = gvHsinh?.Rows[gvHsinh.CurrentCell.RowIndex]?.Cells[1]?.Value?.ToString()?.Trim();
            txtCmnd.Text = gvHsinh?.Rows[gvHsinh.CurrentCell.RowIndex]?.Cells[2]?.Value?.ToString()?.Trim();
            dtpDate.Text = gvHsinh?.Rows[gvHsinh.CurrentCell.RowIndex]?.Cells[3]?.Value?.ToString()?.Trim();
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
