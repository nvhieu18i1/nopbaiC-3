using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh28._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap danh sach cua sach:");
            n = Int32.Parse(Console.ReadLine());
            Sachgiaokhoa[] mang = new Sachgiaokhoa[n];
                for(int i =0; i <0; i++)
            {
                mang[i] = new Sachgiaokhoa();
                mang[i].nhap();
                mang[i].In();
            }
            Sachgiaokhoa sach = new Sachgiaokhoa();
            sach.nhap();
            sach.In();
            Console.ReadLine();
        }
    }
}
