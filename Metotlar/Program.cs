using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Adi = "Elma";
            product1.fiyat = 15;
            product1.aciklama = "Amasya Elması";

            Product product2 = new Product();

            product2.Adi = "Karpuz";
            product2.fiyat = 80;
            product2.aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.fiyat);
                Console.WriteLine(product.aciklama);
                Console.WriteLine("---------");
            }

            Console.WriteLine("------Methods-----");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(product1);
            sepetManager.Ekle2("Armut" , "Yeşil" , 12);
            

            
        }
    }
}
