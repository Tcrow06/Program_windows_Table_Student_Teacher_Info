using System.Data;

namespace ThucHanh1
{
    public class PersonDAO
    {
        public DataTable LoadData(string sqlString){
            DBConnection dbc = new DBConnection();
            return dbc.LoadData(sqlString);
        }
        public void Them(string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public void Sua(string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);
        }
        public void Xoa(Person person, string sqlStr)
        {
            DBConnection db = new DBConnection();
            db.ThucThi(sqlStr);

        }
    }
}
