﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._6_Pramudya_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // Blok 'do' akan dieksekusi minimal satu kali
            do
            {
                Console.Write("Masukkan angka genap: ");
                // Mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Silahkan masukkan angka. ");
                    // Jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut
                    angka = 1;
                    continue; // Lanjutkan ke iterasi berikutnya 
                }
                //Memeriksa apakah angka tersebut ganjil
                if (angka % 2 != 0)
                  {
                    Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
                  }
                // Kondisi diperiksa di akhir. Loop beerlanjut selama angka Ganjil.
                  } while (angka % 2 != 0);
                    Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}");
        }
    }
}
