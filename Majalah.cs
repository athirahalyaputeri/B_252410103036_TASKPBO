
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Majalah : Item
    {
        public string Edisi { get; set; }

        public Majalah(string judul, int tahun, string edisi)
            : base(judul, tahun)
        {
            Edisi = edisi;
        }

        public void InfoEdisi()
        {
            Console.WriteLine("Edisi: " + Edisi);
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Majalah");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Edisi: " + Edisi);
        }
    }
}
