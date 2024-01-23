using System.Data;

namespace ThucHanh1
{
    public class HocSinhDAO 
    {
        PersonDAO pd = new PersonDAO();
        public HocSinhDAO(){}
        public DataTable LoadData()
        {
            string sqlString = string.Format("Select*from HocSinh");
            return pd.LoadData(sqlString);
        }
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format($"insert into HocSinh(Ten, Diachi, Cmnd, Nsinh) Values('{hs.Ten}', '{hs.DiaChi}', '{hs.Cmnd}', '{hs.NgaySinh}')");
            pd.Them(sqlStr);
        }
        public void Sua(HocSinh hs)
        {
            string sqlStr = string.Format($"update HocSinh set Ten='{hs.Ten}', Diachi='{hs.DiaChi}',Nsinh='{Convert.ToDateTime(hs.NgaySinh)}' where Cmnd='{hs.Cmnd}'");
            pd.Sua(sqlStr);
        }
        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format($"delete from HocSinh where Cmnd = '{hs.Cmnd}'");
            pd.Xoa(hs, sqlStr);
        }
    }
}
