using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do Not Repet Yourself
            //type safety - tip güvenliği
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.45;





            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("artış butonu");
            }
            else 
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
