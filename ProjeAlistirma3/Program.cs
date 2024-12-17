using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeAlistirma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunAd = { "Buzdolabı", "Çamaşır Makinesi", "Televizyon", "Isıtıcı", "Kahve Makinesi", "Kurutma Makinesi", "Telefon"};
            int[] stokAdedi = { 10, 8, 5, 6, 3, 7, 0};
            double[] fiyatlar = { 50000.0, 40000.0, 30000.0 , 25000.0, 36000.0, 24000.0, 38000.0};

            string[] sepet = new string[urunAd.Length];
            int[] miktar = new int[urunAd.Length];
            double toplamTutar = 0.0;


            Console.WriteLine("Mağzamıza HosGeldiniz");

            while (true)
            {
                Console.WriteLine("\nStoktaki Ürünler:");
                // Stokları listeleme
                for (int i = 0; i < urunAd.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {urunAd[i]} - Stok: {stokAdedi[i]} - Fiyat: {fiyatlar[i]}TL");
                }

                // Kullanıcıdan ürün seçimi
                Console.Write("\nBir ürün seçin (çıkmak için '0' yazın): ");
                string secim = Console.ReadLine();

                if (secim == "0")
                {
                    break; // Satış işlemini sonlandır
                }

                if (int.TryParse(secim, out int urunIndex) && urunIndex > 0 && urunIndex <= urunAd.Length)
                {
                    urunIndex--; // Diziler sıfırdan başladığı için indisi azaltıyoruz

                    if (stokAdedi[urunIndex] == 0)
                    {
                        Console.WriteLine("Seçilen ürün stokta yok!");
                    }
                    else
                    {
                        // Satın alınacak miktar
                        Console.Write("Kaç adet almak istiyorsunuz? ");
                        string miktarGirdi = Console.ReadLine();

                        if (int.TryParse(miktarGirdi, out int miktarIndex) && miktarIndex > 0)
                        {
                            if (miktarIndex > stokAdedi[urunIndex])
                            {
                                Console.WriteLine("Yeterli stok yok! Maksimum alabileceğiniz miktar: " + stokAdedi[urunIndex]);
                            }
                            else
                            {
                                // Stok düşme ve sepete ekleme
                                stokAdedi[urunIndex] -= miktarIndex;
                                sepet[urunIndex] = urunAd[urunIndex];
                                miktar[urunIndex] += miktarIndex;
                                toplamTutar += miktarIndex * fiyatlar[urunIndex];

                                Console.WriteLine($"{miktarIndex} adet {urunAd[urunIndex]} sepete eklendi.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçerli bir miktar giriniz.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                }
            }

            Console.WriteLine("\n----- Satış Faturası -----");
            Console.WriteLine("Ürün Adı\tAdet\tToplam Fiyat");
            for (int i = 0; i < sepet.Length; i++)
            {
                if (miktar[i] > 0)
                {
                    Console.WriteLine($"{sepet[i]}\t{miktar[i]}\t{miktar[i] * fiyatlar[i]}TL");
                }
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine($"Toplam Tutar: {toplamTutar}TL");
            Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz!");

        }
    }
}
