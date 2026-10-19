
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Item
    {
        public string Judul { get; set; }
        public int Tahun { get; set; }

        public Item(string judul, int tahun)
        {
            Judul = judul;
            Tahun = tahun;
        }

        public virtual void Deskripsi()
        {
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
        }

        public void InfoItem()
        {
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
        }
    }
}
