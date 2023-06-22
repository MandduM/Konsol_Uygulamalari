using System;
using System.Collections.Generic;
using System.Linq;

namespace ToplamHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İkili Sayıların Toplamını Hesaplama Uygulamasına Hoş Geldiniz!");

            Console.WriteLine("Lütfen ikili sayıları girerken her bir ikiliyi bir boşlukla ayırın.");
            Console.WriteLine("Örneğin: 2 3 1 5 2 5 3 3");

            Console.Write("Sayıları girin: ");
            string input = Console.ReadLine();

            int[] numbers = ParseInput(input);

            List<int> results = CalculateSum(numbers);

            PrintResults(results);

            Console.WriteLine("Programı sonlandırmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

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

        static List<int> CalculateSum(int[] numbers)
        {
            Dictionary<int, int> sums = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i += 2)
            {
                int firstNumber = numbers[i];
                int secondNumber = numbers[i + 1];
                int sum = firstNumber + secondNumber;

                if (firstNumber == secondNumber)
                {
                    sum = sum * sum;
                }

                if (sums.ContainsKey(sum))
                {
                    sums[sum]++;
                }
                else
                {
                    sums[sum] = 1;
                }
            }

            return sums.Keys.ToList();
        }

        static void PrintResults(List<int> results)
        {
            foreach (int result in results)
            {
                Console.Write(result + " ");
            }

            Console.WriteLine();
        }
    }
}
