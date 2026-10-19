
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class MajalahAnak : Majalah
    {
        public MajalahAnak(string judul, int tahun, string edisi)
            : base(judul, tahun, edisi)
        {
        }

        public void KategoriAnak()
        {
            Console.WriteLine(
                "Kategori: Pendidikan dan hiburan anak.");
        }

        public override void Deskripsi()
        {
            Console.WriteLine("Jenis: Majalah Anak");
            Console.WriteLine("Judul: " + Judul);
            Console.WriteLine("Tahun: " + Tahun);
            Console.WriteLine("Edisi: " + Edisi);
        }
    }
}
