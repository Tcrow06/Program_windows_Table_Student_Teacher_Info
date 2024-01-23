using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    public abstract class Person
    {
        protected string ten;
        protected string diaChi;
        protected string cmnd;
        protected DateTime ngaySinh;

        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public Person()
        {
            
        }

        public Person(string ten, string diaChi, string cmnd, DateTime ngaySinh)
        {
            this.ten = ten;
            this.DiaChi = diaChi;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
        }
    }
}
