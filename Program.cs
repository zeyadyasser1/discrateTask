using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static bool isprfecet(int x)
        {
            int sum = 0;
           
            for (int i = 1; i < x; i++)
            {
                if (x % i == 0) sum = sum + i;

            }
            if (sum == x) return true;
            return false;

        }
        static void Main(string[] args)
        {
            int y, z;
            Console.WriteLine("enter the first number");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            z = int.Parse(Console.ReadLine());

            for (int i = y; i <= z; i++)
            {
                if (isprfecet(i)) Console.WriteLine("{0},", i);

            }
            Console.ReadKey();
        }
    }
}