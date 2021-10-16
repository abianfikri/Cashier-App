using System;
using System.IO;

namespace Projects_UAS_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Tampilan aa = new Tampilan();
            InputMenu bb = new InputMenu();
            Program cc = new Program();

            // Membuat perulangan for kombinasi switch and case
            for (; ; )
            {
                aa.Home_Page();

                switch (aa.menu)
                {
                    case "1":
                        bb.Nasi_Goreng();
                        Console.WriteLine();
                        break;
                    case "2":
                        bb.Paket_Geprek();
                        Console.WriteLine();
                        break;
                    case "3":
                        bb.Mie_Goreng();
                        Console.WriteLine();
                        break;
                    case "4":
                        bb.kopi();
                        Console.WriteLine();
                        break;
                    case "5":
                        bb.jeruk();
                        Console.WriteLine();
                        break;
                    case "6":
                        bb.teh();
                        Console.WriteLine();
                        break;
                    case "7":
                        bb.Total();
                        Console.WriteLine();

                        // Membuat Stream Writer
                        String Nama_File;
                        try
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("=======Membuat Nama File Nota=======");
                            Console.WriteLine("------------------------------------");
                            // Menuliskan nama file
                            Console.Write("Nama File    : ");
                            Nama_File = Convert.ToString(Console.ReadLine());

                            StreamWriter sw = new StreamWriter("D:\\" + Nama_File + ".txt");

                            sw.WriteLine("-----------------------------------------");
                            sw.WriteLine("============Nota Pembayaran==============");
                            sw.WriteLine("Tanggal          : " + DateTime.Now);
                            sw.WriteLine("Nama Pelanggan   : " + InputMenu.pelanggan);
                            sw.WriteLine("Nama Kasir       : " + InputMenu.kasir);
                            sw.WriteLine("Receipt   : ");

                            sw.WriteLine("==========================================");
                            sw.WriteLine("Menu\t\tJumlah Beli\tTotal Harga");
                            sw.WriteLine("==========================================");

                            for (int baris = 0; baris < 6; baris++)
                            {
                                if (bb.totalBeliMenu[baris] > 0)
                                {
                                    int nBeli = bb.totalBeliMenu[baris] / bb.hargaMenu[baris];

                                    sw.WriteLine(bb.daftarMenu[baris] + "\tx" + nBeli + "\t\tRp." + bb.totalBeliMenu[baris].ToString("N"));
                                }
                            }
                            sw.WriteLine("=====================================");
                            sw.WriteLine("Total Harga\t\t\tRp." + InputMenu.SubTotal);
                            sw.Write("Uang Pembayaran\t\t\tRp." + InputMenu.pembayaran);
                            sw.WriteLine("\n=====================================");
                            if (InputMenu.pembayaran < InputMenu.SubTotal)
                            {

                                sw.WriteLine("Maaf Uang anda tidak Cukup");
                            }
                            else
                            {
                                InputMenu.kembalian = InputMenu.pembayaran - InputMenu.SubTotal;
                                sw.WriteLine("Uang Kembalian\t\t\tRp." + InputMenu.kembalian.ToString("N"));
                            }
                            sw.WriteLine("\n=====================================");
                            sw.WriteLine("Eksekusi Blok Terakhir");
                            sw.WriteLine("Nota Telah di Print\n");
                            sw.WriteLine("\t\t       ^_^ Terima Kasih ^_^");
                            sw.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Kesalahan    : " + e.Message);
                        }
                        finally
                        {
                            Console.WriteLine("Executing finally block");
                        }
                        return;
                        break;
                    default:
                        Console.WriteLine("Maaf pilihan anda Tidak Tersedia !!!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
