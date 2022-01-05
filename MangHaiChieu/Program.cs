using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangHaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("Nhap gia tri phan tu [{0},{1}]: ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
