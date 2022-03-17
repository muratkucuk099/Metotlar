using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);
        }
        public void Ekle2(string urunadi, string aciklama, double fiyat)
        {
            Console.WriteLine("sepete eklendi: " + urunadi);

        }
    }
}
