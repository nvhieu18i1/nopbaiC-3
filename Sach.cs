using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh28._3
{
    class Sach
    {
       protected string Masach;
        protected string ngaynhap;
        protected float dongia;
        protected float soluong;
        public Sach()
        {
            this.Masach = "abc";
            this.ngaynhap = "25";
            this.dongia = (float)15.5000;
            this.soluong = (float)25;

        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma sach:");
            this.Masach = Console.ReadLine();
            Console.WriteLine("Ngay nhap sach:");
            this.ngaynhap =Console.ReadLine();
            Console.WriteLine("Don gia:");
            this.dongia = float.Parse(Console.ReadLine());
            Console.WriteLine("So luong sach:");
            this.soluong = float.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("Ma sach{0} ngay nhap la{1} voi so luong{2} don gia{3}", this.Masach, this.ngaynhap, this.soluong, this.dongia);
        }
    }
}
