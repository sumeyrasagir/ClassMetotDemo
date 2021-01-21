using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri ();
            musteri1.Ad = "Sümeyra";
            musteri1.Soyad = "Sağır";
            musteri1.Yas = 22;
            musteri1.TelNo = "05001231400";
            musteri1.Id = 123456789;
            musteri1.Bakiye = 27000;

            Musteri musteri2 = new Musteri ();
            musteri2.Ad = "Kübra";
            musteri2.Soyad = "Eser";
            musteri2.Yas = 26;
            musteri2.TelNo = "05004568978";
            musteri2.Id = 852147963;
            musteri2.Bakiye = 65000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2  };

            MusteriManager musteriManagers = new MusteriManager();

            musteriManagers.Listele(musteriler);

            musteriManagers.Ekle("Rüveyda", "Kayabaşı", 23, "512347896", 546123897, 43000);

            musteriManagers.Sil(musteri2);

            


        }
    }
}
