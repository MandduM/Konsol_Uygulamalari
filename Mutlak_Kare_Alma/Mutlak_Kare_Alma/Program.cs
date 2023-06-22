using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlak_Kare_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Farkı Hesaplama Uygulamasına Hoş Geldiniz!");

            Console.WriteLine("Lütfen sayıları boşlukla ayırarak girin. Örneğin: 56 45 68 77");
            Console.Write("Sayıları girin: ");
            string input = Console.ReadLine();

            int[] numbers = ParseInput(input);

            int sum = CalculateSum(numbers);

            Console.WriteLine("Sonuç: " + sum);

            Console.WriteLine("Programı sonlandırmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

        // Kullanıcıdan alınan girişi ayrıştıran ve diziye dönüştüren metot
        static int[] ParseInput(string input)
        {
            string[] tokens = input.Split(' ');
            int[] numbers = new int[tokens.Length];

            for (int i = 0; i < tokens.Length; i++)
            {
                numbers[i] = int.Parse(tokens[i]);
            }

            return numbers;
        }

        // Sayıları kontrol ederek hesaplama yapan metot
        static int CalculateSum(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int difference = numbers[i] - 67;

                if (numbers[i] < 67)
                {
                    sum += difference;
                }
                else
                {
                    sum += Math.Abs(difference * difference);
                }
            }

            return sum;
        }
    }
}
/*Bu program, kullanıcıdan alınan bir dizi sayının 67'den küçük veya büyük olduğunu kontrol eden bir hesaplama yapar. 
Program, küçük olan sayıların farklarını toplar ve büyük olan sayıların farklarının mutlak karelerini alarak toplar. 
Sonuç olarak, toplamlarını ekrana yazdırır.

Örneğin, kullanıcıdan "56 45 68 77" gibi bir giriş alırsak, program bu sayıları kontrol eder. 
56 ve 45 67'den küçük olduğu için farklarını alır ve toplar: 56-67 = -11, 45-67 = -22, 
toplam = (-11) + (-22) = -33. 68 ve 77 ise 67'den büyük olduğu için farklarının mutlak karelerini alır 
ve toplar: (68-67)^2 = 1, (77-67)^2 = 100, toplam = 1 + 100 = 101. Sonuç olarak, program ekrana "33 101" yazdırır.

Bu program, kullanıcının belirli bir amaca yönelik olarak girdiği sayıları işleyerek belirli bir hesaplama sonucunu elde etmeyi sağlar.*/
