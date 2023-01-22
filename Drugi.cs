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
            Console.WriteLine("\n4.2");
            int[] arr142 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr242 = { 3, 2, 8, 5, 5, 7 };
            int x42, count = 0;
            if (arr142.Length < arr242.Length)
                x42 = arr142.Length;
            else
                x42 = arr242.Length;
            for (int i = 0; i < x42; i++)
                if (arr142[i] == arr242[i])
                    count++;
            Console.WriteLine("Broj zajedničkih članova je {0}", count);

            Console.ReadKey();
        }

    }
}
    }
}
