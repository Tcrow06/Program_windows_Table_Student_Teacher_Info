using System.Data;
namespace ThucHanh1
{
    public class GiaoVienDao
    {
        PersonDAO pd = new PersonDAO();
        public GiaoVienDao(){}
        public DataTable LoadData()
        {
            string sqlStr = string.Format("Select*from GiaoVien");
            return pd.LoadData(sqlStr);
        }
        public void Them(GiaoVien gv)
        {
            string sqlStr = string.Format($"insert into GiaoVien(Ten, Diachi, Cmnd, Nsinh) Values('{gv.Ten}', '{gv.DiaChi}', '{gv.Cmnd}', '{gv.NgaySinh}')");
            pd.Them(sqlStr);
        }
        public void Sua(GiaoVien gv)
        {     
            string sqlStr = string.Format($"update GiaoVien set Ten='{gv.Ten}', Diachi='{gv.DiaChi}',Nsinh='{gv.NgaySinh}' where Cmnd='{gv.Cmnd}'");
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public void Xoa(GiaoVien gv)
        {
            string sqlStr = string.Format($"delete from GiaoVien where Cmnd = '{gv.Cmnd}'");
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);  
        }
    }
}
