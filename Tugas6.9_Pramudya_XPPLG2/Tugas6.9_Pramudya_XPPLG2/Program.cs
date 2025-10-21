using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas6._9_Pramudya_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Menghitung Perkalian 5: ");

            for (int i = 1; i <= 10; i++)
            {
                total = total * i;
                Console.WriteLine($"5 x {i} = {5 * i}");

            }

        }
    }
}
