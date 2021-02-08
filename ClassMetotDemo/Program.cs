using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Adi = "Sedanur";
            musteri.Soyadi = "Özer";

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Add(musteri);
            musterimanager.Listele(musteri);
            musterimanager.Delete(musteri);
         

        }
    }
}
