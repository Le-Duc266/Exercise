using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinh
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so c: ");
            float c = float.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (delta>0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem: ");
                Console.WriteLine("x1 = " + ( -b - Math.Sqrt(delta)) / 2*a);
                Console.WriteLine("x2 = " + (-b + Math.Sqrt(delta)) / 2 * a);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep: ");
                Console.WriteLine("x1 = x2 =  "+ -b/2*a);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem! ");
            }

        }
    }
}
