using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._3_Pramudya_XPPLG2
{
    internal class Program
    {
        static int Tambah(int a, int b)
        {
            return a + b;
        }
    static void Main(string[] args)
      {
            Console.Write("Masukkan angka pertama: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int hasil = Tambah(x, y);
            Console.WriteLine("Hasil penjumlahan: " + hasil);
      }
    }
}

