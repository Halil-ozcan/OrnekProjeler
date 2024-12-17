using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calisan = { "Halil", "Hasan", "Ahmet", "Mehmet", "Yusuf", "Hamza", "Can", "Fuat", "Kazım" };
            double[] maas = { 20000, 40000, 25000, 22000, 17000, 19000, 45000, 38000, 36000 };

            Console.WriteLine("Şirket Çalışan Listesi : ");
            foreach(var i in Enumerable.Range(0, calisan.Length))
            {
                Console.WriteLine($"{i+1}. {calisan[i]} - Maas : {maas[i]}TL");
            }


            Console.WriteLine("\n Zam Yapılacaklar Listesi");

            for(int i = 0;  i < calisan.Length; i++)
            {
                if (maas[i] < 30000)
                {
                    Console.WriteLine($"{calisan[i]}: ZAM Uygulanacak. (Eski Maas : {maas[i]}TL)");
                    maas[i] *= 1.10;
                }
            }

            Console.WriteLine("\n Yeni Maaş Listesi");

            for (int i = 0;i < calisan.Length; i++)
            {
                Console.WriteLine($"{i + 1} . {calisan[i]} - YeniMaas : {maas[i]}TL");
            }

            Console.WriteLine("\n Bilgilerini Görmek İstediğiniz Çalışanın Sira Numarasini Giriniz : ");

            string numara = Console.ReadLine();

            if (int.TryParse(numara, out int siraNo) && siraNo >= 1 && siraNo <= calisan.Length)
            {
                int index = siraNo - 1;

                Console.WriteLine($"\nÇalışan Bilgileri:\nAd: {calisan[index]}\nMaaş: {maas[index]} TL");

            }
            else
            {
                Console.WriteLine("Geçersiz Sıra Numarası Girdiniz");
            }

        }
    }
}
