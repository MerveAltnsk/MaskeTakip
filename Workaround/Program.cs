// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new Vatandas();


            SelamVer("Merve");
            SelamVer("Henry");
            SelamVer("James");
            SelamVer();


            int sonuc = Topla(2,2);
           


            //Diziler / Arrays

            //string ogrenci1 = "Merve";
            //string ogrenci2 = "Henry";
            //string ogrenci3 = "James";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Merve";
            ogrenciler[1] = "Henry";
            ogrenciler[2] = "James";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++) 
            {
                Console.WriteLine(ogrenciler[i]);
            }


            Console.WriteLine();
            
            string[] sehirler1 = new[] { "Los Angeles","İstanbul","Paris" };
            string[] sehirler2 = new[] { "Eskişehir", "İzmir", "Antalya" };
            Console.WriteLine();


            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirsName = "Merve";
            person1.LastName = "Altınışık";
            person1.DateOfBirthYear = 1999;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirsName = "Henry";


            foreach (string sehir in sehirler1)        //dizi formatındaki yapıları dönüyoruz
            {
                Console.WriteLine(sehir);
            }
            

            Console.WriteLine();

           
            List<string> yeniSehirler1 = new List<string> { "Los Angeles 1", "İstanbul 1", "Paris 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }


        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }


        static int Topla(int sayi1=5, int sayi2 = 5)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }



        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Merve";
            string soyad = "Altınışık";
            int dogumYili = 1999;
            long tcNo = 12354678910;



            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
