using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh28._3
{
    class Sachgiaokhoa:Sach
    {
        string tinhtrang;
        public Sachgiaokhoa():base()
        {
            this.tinhtrang = "moi";
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("Tinh trang sach:");
            this.tinhtrang = Console.ReadLine();
        }
        public double Tinh()
        {
            double tien = 0;
            if (this.tinhtrang == "moi")
                tien = base.soluong * base.dongia;
            if(this.tinhtrang=="cu")
                tien = base.soluong * base.dongia * 0.5;
            return tien;
        }
        public new void In()
        {
            Console.WriteLine("Ma sach{0} co tien la{1}", base.Masach, this.Tinh());
        }
    }
    
}
