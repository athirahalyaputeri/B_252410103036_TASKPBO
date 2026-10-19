
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Novel : Buku
    {
        public Novel(string judul, int tahun, string penulis)
            : base(judul, tahun, penulis)
        {
        }

        public void BacaSinopsis()
        {
            Console.WriteLine(
                "Sinopsis: Kisah perjuangan tokoh utama.");
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Novel");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Penulis: " + Penulis);
        }
    }
}
