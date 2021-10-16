using System;
using System.Collections.Generic;
using System.Text;

namespace Projects_UAS_2
{
    class Tampilan
    {
        public string menu;
        public void Home_Page()
        {
            // Tampilan Menu
            Console.WriteLine("\t\t     =======================================================================");
            Console.WriteLine("\t\t                           Cafeteria Kampus Abadi Jaya");
            Console.WriteLine("\t\t     =======================================================================");
            Console.WriteLine();

            Console.WriteLine("Pilihan Makanan dan Minuman:");
            Console.WriteLine("1. Nasi Goreng               (Rp 15.000)");
            Console.WriteLine("2. Paket Ayam Geprek         (Rp 20.000)");
            Console.WriteLine("3. Mie Goreng                (Rp 10.000)");
            Console.WriteLine("4. Kopi                      (Rp 11.500)");
            Console.WriteLine("5. Es/Panas Jeruk            (Rp 8.500 )");
            Console.WriteLine("6. Es/Panas Teh              (Rp 6.500 )");
            Console.WriteLine("7. Selesai/Exit                         ");

            Console.Write("Choice (1/2/3/4/5/6/7) : ");
            menu = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
