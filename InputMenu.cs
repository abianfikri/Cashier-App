using System;
using System.Collections.Generic;
using System.Text;

namespace Projects_UAS_2
{
    public class InputMenu
    {
        // Deklarasi Variabel
        public static string pelanggan, kasir;
        public static int SubTotal = 0, pembayaran,kembalian;
        // Deklarasi Variabel Array
        public string[] daftarMenu = { "Nasi Goreng", "Paket Ayam Geprek", "Mie Goreng", "Kopi", "Es/Panas Jeruk", "Es/Panas Teh" };
        public int[] totalBeliMenu = { 0, 0, 0, 0, 0, 0 };
        public int[] hargaMenu = { 15000, 20000, 10000, 11500, 8500, 6500 };
        // Deklarasi Variabel pada setiap method
        public static int nNasGor_1, harga_1;
        public static int nGeprek_2, harga_2;
        public static int nMiGor_3, harga_3; 
        public static int nKopi_4, harga_4;
        public static int nJeruk_5, harga_5;
        public static int nTeh_6, harga_6;
        
        // Pembuatan Method input,compute, dan outputdata
        public void Nasi_Goreng()
        {
            // Input Data
            Console.Write("Berapa Porsi Nasi Goreng yang di pesan : ");
            nNasGor_1 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_1 = nNasGor_1 * hargaMenu[0];

            // OutputData
            Console.Write("Harganya     : Rp." +harga_1.ToString("N"));
            Console.WriteLine();

            // Update harga total array setiap menu dengan index 0
            totalBeliMenu[0] += harga_1;
        }
        public void Paket_Geprek()
        {
            // Input Data
            Console.Write("Berapa Porsi Paket Ayam Geprek yang di pesan : ");
            nGeprek_2 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_2 = nGeprek_2 * hargaMenu[1];

            // Output Data
            Console.Write("Harganya     : Rp." + harga_2.ToString("N"));
            Console.WriteLine();

            // Update harga total array setiap menu dengan index 1
            totalBeliMenu[1] += harga_2;
        }
        public void Mie_Goreng()
        {
            // Input Data
            Console.Write("Berapa Porsi Mie Goreng yang di pesan    : ");
            nMiGor_3 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_3 = nMiGor_3 * hargaMenu[2];

            // Output Data
            Console.Write("Harganya     : Rp." + harga_3.ToString("N"));

            // Update harga total array setiap menu dengan index 2
            totalBeliMenu[2] += harga_3;
        }
        public void kopi()
        {
            // InputData
            Console.Write("Berapa item Kopi yang di Pesan      : ");
            nKopi_4 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_4 = nKopi_4 * hargaMenu[3];

            // OutputData
            Console.Write("Harganya     : Rp." + harga_4.ToString("N"));

            // Update harga total array setiap menu dengan index 3
            totalBeliMenu[3] += harga_4;
        }
        public void jeruk()
        {
            // InputData
            Console.Write("Berapa item Es/Panas Jeruk yang di Pesan     : ");
            nJeruk_5 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_5 = nJeruk_5 * hargaMenu[4];

            // Output Data
            Console.Write("Harganya     : Rp." + harga_5.ToString("N"));

            // Update harga total array setiap menu dengan index 4
            totalBeliMenu[4] += harga_5;
        }
        public void teh()
        {
            // InputData
            Console.Write("Berapa Item Es/Panas Teh yang di Pesan       : ");
            nTeh_6 = int.Parse(Console.ReadLine());

            // Compute Data
            harga_6 = nTeh_6 * hargaMenu[5];

            // Output Data
            Console.Write("Harganya     : Rp." + harga_6.ToString("N"));

            // Update harga  total array setiap menu dengan index 5
            totalBeliMenu[5] += harga_6;
        }
        public void Total()
        {
            // Pembuatan Tampulan Nota
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("============Nota Pembayaran==============");
            Console.WriteLine("-----------------------------------------");

            // Membuat Tanggal
            Console.WriteLine("Tanggal          : " + DateTime.Now);

            // Input Nama Pelanggan
            Console.Write("Nama Pelanggan   : ");
            pelanggan = Console.ReadLine();

            // Input Nama Kasir
            Console.Write("Nama Kasir       : ");
            kasir = Console.ReadLine();

            // Menampilkan Daftar Belanjaan
            Console.WriteLine("Receipt : "); 
            Console.WriteLine("==========================================");
            Console.WriteLine("Menu\t\tJumlah Beli\tTotal Harga");
            Console.WriteLine("==========================================");

            // Penggunaan Looping "FOR" yg berfungsi untuk menampilkan list barang yang di belanjakan
            for (int baris = 0; baris < 6; baris++)
            {
                // Mencetak daftarmenu, jumlah item , dan harga item yg telah kita input lalu di compute
                if (totalBeliMenu[baris] > 0)
                {
                    int nBeli = totalBeliMenu[baris] / hargaMenu[baris];

                    Console.WriteLine(daftarMenu[baris] + "\tx" + nBeli + "\t\tRp." + totalBeliMenu[baris].ToString("N"));

                    // Update subtotal
                    SubTotal += totalBeliMenu[baris];
                }
            }
            // Tampilan Total Harga, uang pembayaran, uang kembalian yang mana jika uang pembayaran lebih kecil daripada subtotal
            // Maka "uang yang  tidak cukup" sebaliknya jika pembayaran > subtotal maka eksekusi kembalian = pembayaran - subtotal
            Console.WriteLine("=====================================");
            Console.WriteLine("Total Harga\t\t\tRp." + SubTotal);
            Console.Write("Uang Pembayaran\t\t\tRp.");
            pembayaran = int.Parse(Console.ReadLine());
            Console.WriteLine("\n=====================================");

            // Kembalian yang mana jika uang pembayaran lebih kecil daripada subtotal
            // Maka "uang yang  tidak cukup" sebaliknya jika pembayaran > subtotal maka eksekusi kembalian = pembayaran - subtotal
            if (pembayaran < SubTotal)
            {

                Console.WriteLine("Maaf Uang anda tidak Cukup");
            }
            else
            {
                kembalian = pembayaran - SubTotal;
                Console.WriteLine("Uang Kembalian\t\t\tRp." + kembalian.ToString("N"));
            }
            Console.ReadKey();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("Eksekusi Blok Terakhir");
            Console.WriteLine("Nota Telah di Print\n");
            Console.WriteLine("\t\t      ^_^ Terima Kasih ^_^");
        }
    }
}
