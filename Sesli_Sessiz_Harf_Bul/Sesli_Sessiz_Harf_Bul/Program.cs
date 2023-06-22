using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesli_Sessiz_Harf_Bul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sessiz Kontrol Uygulamasına Hoş Geldiniz!\nÖRNEK: Merhaba Ali\nSonuçlar:\nTrue\nFalse");

            Console.Write("Bir string ifade girin: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Console.WriteLine("Sonuçlar:");

            foreach (string word in words)
            {
                bool result = CheckConsecutiveConsonants(word);
                Console.WriteLine(result);
            }

            Console.WriteLine("Programı sonlandırmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

        // Yanyana 2 tane sessiz harf kontrolünü gerçekleştiren metot
        static bool CheckConsecutiveConsonants(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                char currentChar = word[i];
                char nextChar = word[i + 1];

                if (IsConsonant(currentChar) && IsConsonant(nextChar))
                {
                    return true;
                }
            }

            return false;
        }

        // Sessiz harf kontrolü yapan yardımcı metot
        static bool IsConsonant(char c)
        {
            char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };

            if (Array.IndexOf(consonants, char.ToLower(c)) >= 0)
            {
                return true;
            }

            return false;
        }
    }
}
/*Bu program, kullanıcının girdiği string ifade içerisinde her bir kelimenin içinde yanyana 2 tane sessiz harf olup olmadığını kontrol eder. 
 Eğer bir kelimenin içinde yanyana 2 sessiz harf bulunuyorsa, sonuç true olarak döner; aksi halde sonuç false olur. 
 Program, sessiz harflerin yanyana geçip geçmediğini kontrol etmek için kullanılır.*/
