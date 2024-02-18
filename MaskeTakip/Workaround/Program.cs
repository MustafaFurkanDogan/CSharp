

using Businness.Concrete;
using Entities.Concrete;

namespace Workaround {
    //string Referans tiptir
    class Program
    {
        static void Main(string[] args)
        {
           // Degiskenler(); 
           //Vatandas vatandas1 = new Vatandas();
            //vatandas1.

            SelamVer("Furkan");
            SelamVer("Berra");
            SelamVer();

            int sonuç= Topla(5,10);

            //Dizler\Arrays
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Berra";
            students[2] = "Furkan";

            students = new string[4];
            students[3] = "Fatma";

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);     
            }

            string[] cityes1 = new[] {"Ankara","İstanbul","İzmir" };
            string[] cityes2 = new[] {"Bursa","Antalya","Diyarbakır" };

            cityes2 = cityes1;
            cityes1[0] = "Adana";
            Console.WriteLine(cityes1[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NatıonalIdentitiy = 123;

            Person person2 = new Person();
            person2.FirstName = "Furkan";

            foreach (string city in cityes2)
            {
                Console.WriteLine(city);
                
            }

            List<string> newcityes1 = new List<string> { "Ankara 1", "Adana 1", "Konya 1" };
            newcityes1.Add("İzmir 1");

            foreach (var city in cityes1)
            {
                Console.WriteLine(city);
            }

            PttManager pttManager = new PttManager (new PersonManager());
            pttManager.GiveMask(person1);



            Console.ReadLine();
        }


        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayı1 , int sayı2)
        {
            int sonuc = sayı1 + sayı2;
            Console.WriteLine("Topam :"+ sonuc.ToString());
            return sonuc;
        }


        //Pascal Casing
        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayı = 100;
            bool girisYapılmısMı = false;

            string ad = "Furkan";
            string soyad = "Doğan";
            int dogumYili = 2001;
            long tcNo = 123456789;
            
            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
        //pascal casing
        public class Vatandas{
            public int Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYılı { get; set; }

            public long TcNo { get; set; }

            
        }
    }



}
