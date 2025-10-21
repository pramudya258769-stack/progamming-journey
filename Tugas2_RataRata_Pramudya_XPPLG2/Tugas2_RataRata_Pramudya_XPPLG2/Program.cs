using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_RataRata_Pramudya_XPPLG2
{
    internal class Program
    {
        static double RataRata(double angka1, double angka2, double angka3)
        {
            return (angka1 + angka2 + angka3) / 3;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai pertama \t: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai kedua \t: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan nilai ketiga \t: ");
            double angka3 = Convert.ToDouble(Console.ReadLine());

            double rataRata = (angka1 +  angka2 + angka3) /3;
            Console.WriteLine("Hasil Rata-Rata nilai \t: " + rataRata);
        }
    }
}
