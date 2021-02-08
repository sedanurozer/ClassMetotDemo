using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

    {
     public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + musteri.Adi + musteri.Soyadi +"Bilgilerine sahip müşteri sisteme başarılı bir şekilde eklenmiştir.");
        }
        public void Listele(Musteri musteri1)
        {
            Console.WriteLine("Müşteri Id= " + musteri1.Id);
            Console.WriteLine("Müşteri Adı= " + musteri1.Adi);
            Console.WriteLine("Müşteri Soyadı= " + musteri1.Soyadi);
            Console.WriteLine("Müşteri bilgileri listelenmiştir.....");
        }


     public void Delete(Musteri musteri1)
        {
            Console.WriteLine(musteri1.Id + musteri1.Adi  + musteri1.Soyadi + "Bilgilerine sahip müşteri sistemden başarılı bir şekilde silinmiştir.");
            
            
        }
    }
}
