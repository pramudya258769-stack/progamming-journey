using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1_Fungsi_Pramudya_XPPLG2
{
    internal class Program
    {
        static double Perkalian(double angka1, double angka2, double angka3)
        {
            return angka1 * angka2 * angka3;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama\t: ");
            double angka1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua\t: ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka ketiga\t: ");
            double angka3 = Convert.ToDouble(Console.ReadLine());

            double hasil = Perkalian(angka1, angka2, angka3);
            Console.WriteLine("Hasil perkalian adalah\t: " + hasil);
        }
    }
}
