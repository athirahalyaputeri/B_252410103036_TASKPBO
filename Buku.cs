
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Buku : Item
    {
        public string Penulis { get; set; }

        public Buku(string judul, int tahun, string penulis)
            : base(judul, tahun)
        {
            Penulis = penulis;
        }

        public void CekPenulis()
        {
            Console.WriteLine("Penulis: " + Penulis);
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Buku");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Penulis: " + Penulis);
        }
    }
}
