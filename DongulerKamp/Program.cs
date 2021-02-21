using System;

namespace DongulerKamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurslar";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "C++";


            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            // array- dizi

            string[] kurslar = new string[] {" Yazılım geliştirme kampı, programlamaya başlangıç için temel kurslar, java, python,c#"};


            for (int i = 0; i<kurslar.Length; i=i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine ("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu- footer");
        }
    }
}
