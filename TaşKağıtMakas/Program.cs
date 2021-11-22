using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaşKağıtMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Taş Kağıt Makas
            string oyuncuSecim = "a", bilgisayarSecim = "b", secimKontrol = "c";
            int oyuncuSonuc = 0, bilgisayarSonuc = 0, sayi;
            Random rnd = new Random();
            basadon:

            Console.WriteLine("Taş Kağıt Makas Oyununa Hoşgeldiniz");
            Console.WriteLine("Oyun 7 kere dönecektir!");
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine("Lütfen " + i + ". seçiminizi yapınız: \nTaş için = t \nKağıt için = k \nMakas için = m");
                oyuncuSecim = (Console.ReadLine());
                if (oyuncuSecim.ToLower() == "t")
                {
                    secimKontrol = "taş";
                }
                if (oyuncuSecim.ToLower() == "k")
                {
                    secimKontrol = "kağıt";
                }
                if (oyuncuSecim.ToLower() == "m")
                {
                    secimKontrol = "makas";
                }



                sayi = rnd.Next(1, 4);
                if (sayi == 1)
                {
                    bilgisayarSecim = "taş";
                }
                if (sayi == 2)
                {
                    bilgisayarSecim = "kağıt";
                }
                if (sayi == 3)
                {
                    bilgisayarSecim = "makas";
                }

                Console.WriteLine("Oyuncu: " + secimKontrol + "\nBilgisayar: " + bilgisayarSecim);
                if (secimKontrol == "taş" && bilgisayarSecim == "kağıt")
                {
                    Console.WriteLine("Oyunu bilgisayar kazandı!");
                    bilgisayarSonuc++;
                }
                if (secimKontrol == "taş" && bilgisayarSecim == "makas")
                {
                    Console.WriteLine("Oyunu oyuncu  kazandı!");
                    oyuncuSonuc++;
                }
                if (secimKontrol == "taş" && bilgisayarSecim == "taş")
                {
                    Console.WriteLine("Oyunu berabere!");

                }
                if (secimKontrol == "kağıt" && bilgisayarSecim == "taş")
                {
                    Console.WriteLine("Oyunu oyuncu kazandı kazandı!");
                    oyuncuSonuc++;
                }
                if (secimKontrol == "kağıt" && bilgisayarSecim == "makas")
                {
                    Console.WriteLine("Oyunu bilgisayar kazandı!");
                    bilgisayarSonuc++;
                }
                if (secimKontrol == "kağıt" && bilgisayarSecim == "kağıt")
                {
                    Console.WriteLine("Oyunu berabere!");

                }
                if (secimKontrol == "makas" && bilgisayarSecim == "taş")
                {
                    Console.WriteLine("Oyunu bilgisayar kazandı!");
                    bilgisayarSonuc++;
                }
                if (secimKontrol == "makas" && bilgisayarSecim == "kağıt")
                {
                    Console.WriteLine("Oyunu oyuncu kazandı!");
                    oyuncuSonuc++;
                }
                if (secimKontrol == "makas" && bilgisayarSecim == "makas")
                {
                    Console.WriteLine("Oyunu berabere!");
                }

            }
            Console.WriteLine("OYUN BİTMİŞTİR! \nSONUÇLAR! \nOYUNCU:" + oyuncuSonuc + "\tBİLGİSAYAR:" + bilgisayarSonuc);

            if (oyuncuSonuc > bilgisayarSonuc)
            {
                Console.WriteLine("Tebrikler Oyunu Kazandınız:)");
            }
            if (oyuncuSonuc < bilgisayarSonuc)
            {
                Console.WriteLine("Üzgünüm Oyunu Kaybettiniz:(");
            }
            if (oyuncuSonuc == bilgisayarSonuc)
            {
                Console.WriteLine("Oyun Berabere Bitmiştir.");
            }
            Console.WriteLine("Oyunu tekrar oynamak istermisiniz? \nE/H?");
            string tekrarOyun = Console.ReadLine();
            if (tekrarOyun.ToLower()=="e")
            {
                Console.WriteLine("Oyun tekrar başlatılıyor...");
                goto basadon;
            }
            else
            {
                Console.WriteLine("Oyun bitmiştir!");
            }






            #endregion
            Console.ReadLine();
        }
    }
}
