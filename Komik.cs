
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Komik : Buku
    {
        public Komik(string judul, int tahun, string penulis)
            : base(judul, tahun, penulis)
        {
        }

        public void TampilkanIlustrasi()
        {
            Console.WriteLine(
                "Ilustrasi: Komik berisi gambar dan percakapan.");
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Komik");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Penulis: " + Penulis);
        }
    }
}
