using Microsoft.Data.SqlClient;


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
            LoadData();
        }
        private void LoadData()
        {
            GiaoVienDao dao = new GiaoVienDao();
            gvGvien.DataSource = dao.LoadData();
          
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDate.Value);
            GiaoVienDao gvd = new GiaoVienDao();
            gvd.Them(gv);
            LoadData();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.Cmnd = txtCmnd.Text;
            
            GiaoVienDao gvd = new GiaoVienDao();
            gvd.Xoa(gv);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtName.Text, txtAddress.Text, txtCmnd.Text, dtpDate.Value);
            GiaoVienDao gvd = new GiaoVienDao();
            gvd.Sua(gv);
            LoadData();
        }

        private void gvGvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gvGvien?.Rows[gvGvien.CurrentCell.RowIndex]?.Cells[0]?.Value?.ToString()?.Trim();
            txtAddress.Text = gvGvien?.Rows[gvGvien.CurrentCell.RowIndex]?.Cells[1]?.Value?.ToString()?.Trim();
            txtCmnd.Text = gvGvien?.Rows[gvGvien.CurrentCell.RowIndex]?.Cells[2]?.Value?.ToString()?.Trim();
            dtpDate.Text = gvGvien?.Rows[gvGvien.CurrentCell.RowIndex]?.Cells[3]?.Value?.ToString()?.Trim();
        }
    }
}
