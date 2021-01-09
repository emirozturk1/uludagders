using System;

namespace Ders1
{
    class Program
    {

        static void Main(string[] args)
        {
            DisplayPicker();
            Console.WriteLine("\n\nPress RETURN key to exit");
            Console.ReadLine();
        }

        private static void DisplayPicker()
        {
            DisplayTitle("Hangi Odevi Test Etmek Istersiniz?");
            try
            {
                var a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1: HangiSayiDahaBuyuk(); break;
                    case 2: CarpimTablosu(); break;
                    case 3: NotOrtalamasi(); break;
                    case 4: KelimeUzunlugu(); break;
                    case 5: CarpmaIslemi(); break;
                    default: Console.WriteLine("Lutfen gecerli bir odev numarasi secin: ( 1-2-3-4-5 )\n"); break;
                }

                if (a > 0 && a <= 5) DisplayPicker();
            }
            catch
            {
                Console.WriteLine("Lutfen gecerli bir giris yapin...");
            }

        }

        private static void HangiSayiDahaBuyuk()
        {
            DisplayTitle("Girilen iki sayidan buyuk olani yazdirma");
            try
            {
                Console.WriteLine("ilk sayiyi girin: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("ikinci sayiyi girin: ");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine($"Buyuk olan sayi: {(a > b ? a : b)} \n\n");
            }
            catch
            {
                Console.WriteLine("Lutfen gecerli bir giris yapin...");

            }
        }

        private static void CarpimTablosu()
        {
            DisplayTitle("Carpim Tablosu");
            string charNewLine = "\n";
            string charTab = "\t";
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    Console.Write($"{i} x {j} = {j * i}");
                    Console.WriteLine(j % 9 == 0 ? charNewLine : charTab);
                }
            }
            Console.WriteLine($"\n\n");
        }

        private static void NotOrtalamasi()
        {
            DisplayTitle("Not Ortalamasi Bulan Metod");
            try
            {
                Console.WriteLine("Vize notunu girin: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Final notunu girin: ");
                double b = Double.Parse(Console.ReadLine());
                var ortalama = (a * 0.4) + (b * 0.6);
                var sonuc = ortalama < 50 ? "KALDI" : "GECTI";
                Console.WriteLine($"Ortalama: {ortalama}\nSonuc: {sonuc}\n\n");
            }
            catch
            {
                Console.WriteLine("Lutfen gecerli bir giris yapin...");

            }
        }

        private static void KelimeUzunlugu()
        {
            DisplayTitle("Kelime Uzunlugu Bulan Metod");
            Console.WriteLine("Kelimeyi giriniz: ");
            var a = Console.ReadLine();
            Console.WriteLine($"Girdiginiz kelimenin uzunlugu: {a.Length}\n\n");
        }

        private static void CarpmaIslemi()
        {
            DisplayTitle("Carpma islemini toplama kullanarak yapan metod");
            try
            {
                Console.WriteLine("ilk tamsayiyi girin: ");
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("ikinci tamsayiyi girin: ");
                var b = int.Parse(Console.ReadLine());
                var c = 0;
                for (var i = 1; i <= a; i++)
                {
                    c += b;
                }
                Console.WriteLine($"Carpma islemi sonucu: {c}\n\n");
            }
            catch
            {
                Console.WriteLine("Lutfen gecerli bir giris yapin...");

            }
        }

        private static void DisplayTitle(string title)
        {
            Console.WriteLine($"------------------------\n{title}:");
        }
    }
}
