using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 4, 3, 2, 1 };

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("     The Numbers in Reverse Order are: ");
            for (int i = arr1.Length; i > 0; i--)
            {
                Console.Write(arr1[i - 1] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
