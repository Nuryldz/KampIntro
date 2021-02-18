using System;

namespace Kurslar
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiro";
            kurs1.IzlenmeOrani = 68;



            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 48;



            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java";
            kurs3.Egitmen = "Kerem Yavaş";
            kurs3.IzlenmeOrani = 50;


            //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].KursAdi);
            }

            

            //Console.WriteLine("hello word!");



        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani{ get; set; }
    }
    
}
