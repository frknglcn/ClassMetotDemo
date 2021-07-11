using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Furkan";
            musteri1.Soyad = "Gülcan";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Gülcan";
            musteri2.Soyad = "Furkan";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEKleme(musteri1);
            musteriManager.MusteriEKleme(musteri2);
            musteriManager.MusteriSİlme(musteri2);
            musteriManager.MusteriSİlme(musteri2);


            musteriManager.MusteriListeleme(musteriler);

        }
    }
}
