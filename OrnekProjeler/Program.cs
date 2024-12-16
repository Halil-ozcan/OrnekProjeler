using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProjeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "Çay", "Kahve", "Pasta", "Su", "Gazoz", "Sade Soda", "Meyveli Soda", "Kola" };
            double[] fiyatlar = { 50.00, 100.00, 150.00, 20.00, 45.00, 30.00, 40.00, 60.00 };

            double ToplamTutar = 0;
            string secim = "";

            Console.WriteLine("Kafeterya Yönetim Sistemine Hoş Geldiniz");

           
            
            while (true)
            {
                Console.WriteLine("\n----------Menu-------------");
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]} - {fiyatlar[i]}TL");
                }

                Console.Write("\nLütfen bir ürün seçin (1-4) veya 'çıkış' yazarak işlemi sonlandırın: ");
                secim = Console.ReadLine();

                if(secim.Equals("çıkış", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if(int.TryParse(secim, out int urunNumarasi) && urunNumarasi >=1 && urunNumarasi <= menu.Length)
                {
                    Console.Write($"Kaç adet {menu[urunNumarasi - 1]} almak istiyorsunuz? ");
                    string adetGirdisi = Console.ReadLine();

                    if (int.TryParse(adetGirdisi, out int adet) && adet > 0)
                    {
                        double urunTutari = adet * fiyatlar[urunNumarasi - 1];
                        ToplamTutar += urunTutari;
                        Console.WriteLine($"{adet} adet {menu[urunNumarasi - 1]} için toplam: {urunTutari} TL");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir adet giriniz!");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim! Lütfen menüdeki ürün numaralarından birini seçiniz.");
                }
            }

            Console.WriteLine($"\nToplam Sipariş Tutarınız: {ToplamTutar}TL");
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz!");


        }
    }
}
