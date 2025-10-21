using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._2_Pramudya_XPPLG2
{
    internal class Program
    {
        static void SapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini!");
        }
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Masukkan nama Anda: ");
                string namaSiswa = Console.ReadLine();
                SapaNama(namaSiswa); // Memanggil fungsi dengan argumen
            }
        }
    }
}
