
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class MajalahTeknologi : Majalah
    {
        public MajalahTeknologi(
            string judul, int tahun, string edisi)
            : base(judul, tahun, edisi)
        {
        }

        public void TopikTeknologi()
        {
            Console.WriteLine(
                "Topik: Komputer, AI, dan teknologi.");
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Majalah Teknologi");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Edisi: " + Edisi);
        }
    }
}
