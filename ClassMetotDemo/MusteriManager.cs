using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEKleme(Musteri musteri)
        {
            Console.WriteLine("Musteri EKlendi : "+musteri.Ad+" "+musteri.Soyad);
        }
        public void MusteriListeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Musteriler Listeleniyor");
            foreach (var musteri  in musteriler)
            {
                
                Console.WriteLine(musteri.Ad+musteri.Soyad);
            }
           // Console.WriteLine("Musteri EKlendi : " + musteri.Ad + " " + musteri.Soyad);
        }
        public void MusteriSİlme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi : " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
