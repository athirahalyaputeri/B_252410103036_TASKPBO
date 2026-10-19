
using System;
using System.Collections.Generic;
using System.Text;

namespace Praktikum_PBO
{
    internal class Perpustakaan
    {
        private List<Item> daftarItem = new List<Item>();

        public void TambahItem(Item item)
        {
            daftarItem.Add(item);
        }

        public void DaftarItem()
        {
            foreach (Item item in daftarItem)
            {
                item.Deskripsi();
                Console.WriteLine("--------------------");
            }
        }
    }
}
