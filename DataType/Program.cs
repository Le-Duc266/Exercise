using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Program
    {
        private static void ThamTri(int a)
        {
            a ++ ;
            Console.WriteLine("Tham tri: " + a);
        }
        private static void ThamChieuRef(ref int a)
        {
            a++;
            Console.WriteLine("Tham chieu ref: " + a);
        }
        private static void ThamChieuOut(out int b)
        {
            b = 2;
            Console.WriteLine("Tham chieu out: " + b);
        }

        static void Main(string[] args)
        {
            int x = 5;
            int y;
            ThamTri(x);
            Console.WriteLine("Gia tri dau vao tham tri: " + x);
            ThamChieuRef(ref x);
            Console.WriteLine("Ket qua tham chieu ref: " + x);
            ThamChieuOut(out y);
            Console.WriteLine("Ket qua tham chieu out: " + y);
        }
    }
}
