
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perpustakaan perpus = new Perpustakaan();

            Novel novel = new Novel(
                "Laskar Pelangi", 2005, "Andrea Hirata");

            Komik komik = new Komik(
                "Petualangan Si Juki", 2017, "Faza Meonk");

            Majalah majalah = new Majalah(
                "National Geographic", 2024, "Edisi Januari");

            MajalahAnak anak = new MajalahAnak(
                "Bobo", 2024, "Edisi Februari");

            MajalahTeknologi teknologi = new MajalahTeknologi(
                "PC Magazine", 2025, "Edisi Maret");

            perpus.TambahItem(novel);
            perpus.TambahItem(komik);
            perpus.TambahItem(majalah);
            perpus.TambahItem(anak);
            perpus.TambahItem(teknologi);

            Console.WriteLine("=== DAFTAR PERPUSTAKAAN ===");
            perpus.DaftarItem();

            Console.WriteLine("\n=== SOAL 1 ===");
            novel.Deskripsi();
            majalah.Deskripsi();

            Console.WriteLine("\n=== SOAL 2 ===");
            novel.BacaSinopsis();

            Console.WriteLine("\n=== SOAL 3 ===");
            novel.InfoItem();
            novel.CekPenulis();

            Console.WriteLine("\n=== SOAL 4 ===");
            teknologi.TopikTeknologi();

            Console.WriteLine("\n=== SOAL 5 ===");
            Item item = komik;
            item.Deskripsi();

            Console.WriteLine("\n=== METHOD KHUSUS ===");
            komik.TampilkanIlustrasi();
            majalah.InfoEdisi();
            anak.KategoriAnak();

            Console.WriteLine("\nProgram selesai.");
            Console.ReadKey();
        }
    }
}
