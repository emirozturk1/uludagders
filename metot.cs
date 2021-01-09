using System;

namespace metotornegim
{
        class Program
        {

        static void Main(string[] args)
        {
                carpim();

                VizeFinal(56, 85);
                BuyukSayi();
            metinuzunluk();
        }
            public static void carpim()
            {
                for (int x = 1; x <= 10; x++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write("{0}*{1}={2}\t", i, x, (x * i));
                    }
                }
            }
            public static void metinuzunluk()
        {
            Console.WriteLine("Yazı Girin : ");
            string yazi = Console.ReadLine();
            int uzunluk = yazi.Length;
            Console.WriteLine("Uzunlugu = " + uzunluk);
            Console.ReadLine();
        }
            public static void VizeFinal(int vize, int final)
            {

                double ortalama;
                ortalama = (vize * 40 / 100) + (final * 60 / 100);
                Console.WriteLine("Ortalamanız: " + ortalama);

            }

            public static void BuyukSayi()
            {
                Console.WriteLine("Birinci sayiyi girin: ");
                double i = Double.Parse(Console.ReadLine());

                Console.WriteLine("ikinci sayiyi girin: ");
                double a = Double.Parse(Console.ReadLine());

                Console.WriteLine($"Buyuk olan sayi: {(i > a ? i : a)} \n\n");
                
            }

          
        }
    }
   
