using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string musteriAd, string musteriSoyad, int Yas, string TelNo, int Id, int Bakiye)
        {
            Console.WriteLine("Yeni müşteri veritabanına eklendi  !");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Seçilen müşteri silindi: " + musteri.Id);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşterinin adı: " + musteri.Ad);
                Console.WriteLine("Müşterinin soyadı: " + musteri.Soyad);
                Console.WriteLine("Müşterinin yaşı: " + musteri.Yas);
                Console.WriteLine("Müşterinin telefon numarası: " + musteri.TelNo);
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri bakiyesi: " + musteri.Bakiye);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
