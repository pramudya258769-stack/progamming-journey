using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas3_Konversi_Pramudya_XPPLG2
{
    internal class Program
    {
        static double fahr (double suhu1)
        {
            return (suhu1 * 9 / 5) + 32;
        } 
        static void Main(string[] args)
        {
                    Console.Write("Masukkan suhu dalam bentuk celcius: ");
                    double c = Convert.ToDouble(Console.ReadLine());

                    double fahrenheit = fahr(c);
                    Console.WriteLine("Hasil konversi celcius ke Fahrenheit: " + fahrenheit + "°C");
        }
    }
}
