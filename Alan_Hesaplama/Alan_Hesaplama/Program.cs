using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometrik Hesaplama Uygulamasına Hoş Geldiniz!\n İşlem Yapmak İstediğiniz Numarayı Girin");

            Console.Write("Geometrik şekli girin\n 1-Daire\n 2-Üçgen\n 3-Kare\n 4-Dikdörtgen\n\n CEVAP : ");
            string sekil = Console.ReadLine();

            Hesaplayici hesaplayici;

            switch (sekil.ToLower())
            {
                case "1":
                    hesaplayici = new DaireHesaplayici();
                    break;
                case "2":
                    hesaplayici = new UcgenHesaplayici();
                    break;
                case "3":
                    hesaplayici = new KareHesaplayici();
                    break;
                case "4":
                    hesaplayici = new DikdortgenHesaplayici();
                    break;
                default:
                    Console.WriteLine("Geçersiz bir geometrik şekil girdiniz!");
                    Console.ReadLine();
                    return;
            }

            double sonuc = hesaplayici.Hesapla();

            Console.WriteLine($"Hesaplanan sonuç: {sonuc}");
            Console.ReadLine();
        }
    }

    
}
