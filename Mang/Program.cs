using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int tmp;
            int[] arr = { 5, 3, 2, 8, 9, 6 };
            Console.Write("\n------------Do dai mang-------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Cac gia tri cua mang: {0}", arr[i]);
            }
            // xep mang tang dan
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.Write("\n------------Tang dan---------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Gia tri mang sau khi sap xep tang dan: {0}", arr[i]);
            }

            // xep mang giam dan
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            Console.Write("\n------------Giam dan---------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Gia tri mang sau khi sap xep giam dan: {0}", arr[i]);
            }
            Console.Write("\n---------Xoa so 3------------\n");
            // xoa phan tu trong mang bang linq
            int del = 3;
            arr = arr.Where(x => x != del).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Gia tri mang sau khi xoa: {0}", arr[i]);
            }
        }
    }
}
