using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai2hieu
{
    class doantua
    {
        string Madoantau;
        int Soluongkhach;
        public void Nhap()
        {
            Console.WriteLine("Nhap ma doan tau");
            this.Madoantau = Console.ReadLine();
            Console.WriteLine("Nhap so luong khach");
            this.Soluongkhach = Convert.ToInt32(Console.ReadLine());

        }
        public double tinhtien()
        {
            double tien;
            if (this.Soluongkhach < 100) tien = this.Soluongkhach * 100000;
            else tien = this.Soluongkhach * 80000;
            return tien;
        }
        public void intien()
        {
            Console.WriteLine("Ma doan tau {0} co tien {1}", this.Madoantau, this.tinhtien());
        }
    }
}
