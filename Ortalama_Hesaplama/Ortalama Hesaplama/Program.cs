using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Fibonacci serisinin derinliğini giriniz: ");
                int derinlik = Convert.ToInt32(Console.ReadLine());

                FibonacciHesaplamaService fibonacciHesaplamaService = new FibonacciHesaplamaService();
                double ortalama = fibonacciHesaplamaService.HesaplaOrtalama(derinlik);

                Console.WriteLine($"Fibonacci serisinin ortalaması: {ortalama}");

                Console.ReadLine();
            }
        }

        public class FibonacciHesaplamaService
        {
            public double HesaplaOrtalama(int derinlik)
            {
                int[] fibonacciSerisi = FibonacciSerisiOlustur(derinlik);
                double ortalama = OrtalamaHesapla(fibonacciSerisi);

                return ortalama;
            }

            private int[] FibonacciSerisiOlustur(int derinlik)
            {
                int[] fibonacciSerisi = new int[derinlik];

                fibonacciSerisi[0] = 0;
                fibonacciSerisi[1] = 1;

                for (int i = 2; i < derinlik; i++)
                {
                    fibonacciSerisi[i] = fibonacciSerisi[i - 1] + fibonacciSerisi[i - 2];
                }

                return fibonacciSerisi;
            }

            private double OrtalamaHesapla(int[] dizi)
            {
                int toplam = 0;

                for (int i = 0; i < dizi.Length; i++)
                {
                    toplam += dizi[i];
                }

                double ortalama = (double)toplam / dizi.Length;
                return ortalama;
            }
        }
    }

