using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Kütür Kütür";

            Urun urun2 = new Urun();
            urun2.Adi = "Armut";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Deveci Armutu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");

            }

            Console.WriteLine("-------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "yeşil armut", 12,100);
            sepetManager.Ekle2("elma", "yeşil ", 12,100);
            sepetManager.Ekle2("elma", "kırmızı", 12,1000);
            

        }


    }
}
