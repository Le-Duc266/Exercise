using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Day la chuoi thu 1!";
            string b = " ngay sau la chuoi thu 2!";
            string demo = " chuoiKhongvieTroi ";
            // so sanh chuoi
            if (a==b)
            {
                Console.WriteLine("Giong nhau khong phan biet chu hoa và chu thuong");
            }
            else if (a!=b)
            {
                Console.WriteLine("chuoi a nho hon chuoi b");
            }
            else
            {
                Console.WriteLine("chuoi a lon hon chuoi b");
            }
            // indexof
            Console.WriteLine(a.IndexOf("chuoi"));
            //StartsWith kiem tra ky tu dau chuoi
            Console.WriteLine(a.StartsWith("D"));
            // EndWith kiem tra ky tu cuoi chuoi
            Console.WriteLine(a.EndsWith("!"));
            // noi chuoi bang concat
            Console.WriteLine(string.Concat(a, b));
            // tach chuoi bang slipt
            string[] chuoitach = demo.Split('g');
            foreach (var item in chuoitach)
            {
                Console.WriteLine(item);
            }
            // chuyen doi chu thuong
            Console.WriteLine(demo.ToLower());
            // chuyen doi chu hoa
            Console.WriteLine(demo.ToUpper());
            // loai bo kí tu khoang trang
            Console.WriteLine(demo.Trim());
        }
    }
}
