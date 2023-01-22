using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPZ3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n4.1");
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            string s41;
            int x41, n1 = 0, n2 = 0;
            do
            {
                Console.WriteLine("Upišite broj:");
                s41 = Console.ReadLine();
                x41 = Convert.ToInt32(s41);
                if (x41 % 2 != 0)
                    arr1[n1++] = x41;
                else
                    arr2[n2++] = x41;
            } while (x41 != 0 && n1 < 10 && n2 < 10);
            Console.WriteLine();
            for (int i = 0; i < n1; i++)
                Console.WriteLine(arr1[i]);
            Console.WriteLine();
            for (int i = 0; i < n2; i++)
                Console.WriteLine(arr2[i]);
        }
    }
}
