using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace Voting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre-defined kategorileri tanımla
            Dictionary<int, string> kategoriler = new Dictionary<int, string>()
        {
            { 1, "Film" },
            { 2, "Spor" },
            { 3, "Teknoloji" }
        };

            Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");

            // Kullanıcı bilgilerini kaydetmek için bir değişken tanımla
            string kullaniciAdi = "";

            while (true)
            {
                // Eğer kullanıcı kayıtlı değilse kayıt olmasını iste
                if (string.IsNullOrEmpty(kullaniciAdi))
                {
                    Console.Write("Kullanıcı adınızı girin: ");
                    kullaniciAdi = Console.ReadLine();

                    Console.WriteLine($"Hoş geldin, {kullaniciAdi}!");
                }

                // Kategorileri listeleyerek kullanıcıdan seçim yapmasını iste
                Console.WriteLine("Lütfen aşağıdaki kategorilerden birini seçin:");
                foreach (var kvp in kategoriler)
                {
                    Console.WriteLine($"{kvp.Key}-{kvp.Value}");
                }

                Console.Write("Seçiminizi yapın (kategori numarası): ");
                int secim;
                while (!int.TryParse(Console.ReadLine(), out secim) || !kategoriler.ContainsKey(secim))
                {
                    Console.Write("Geçersiz seçim! Lütfen bir kategori numarası girin: ");
                }

                string secilenKategori = kategoriler[secim];
                Console.WriteLine($"Oyunuz {secilenKategori} kategorisine kaydedildi.");

                // Oylama devam ediyor mu diye sormak ve programı sonlandırmak için seçenek sunmak
                Console.Write("Başka bir kategoriye oy vermek istiyor musunuz? (E/H): ");
                string devamSecimi = Console.ReadLine();

                if (devamSecimi.ToUpper() != "E")
                {
                    break;
                }
            }

            // Oylama sonuçlarını hesapla ve ekrana yazdır
            int toplamOySayisi = 0;
            Dictionary<string, int> kategoriOylari = new Dictionary<string, int>();

            foreach (var kategori in kategoriler.Values)
            {
                kategoriOylari[kategori] = 0;
            }

            Console.WriteLine("\nVoting Sonuçları");
            foreach (var kvp in kategoriOylari)
            {
                Console.WriteLine($"{kvp.Key} kategorisi: {kvp.Value} oy");
                toplamOySayisi += kvp.Value;
            }

            Console.WriteLine($"Toplam oy sayısı: {toplamOySayisi}");

            // Teşekkür mesajını ekrana yazdır
            Console.WriteLine("\nProgram sonlandırılıyor. Teşekkürler!");

            // Bekleme süresini ekle
            Thread.Sleep(2000);
        }
    }
}