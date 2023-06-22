using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakter_Yer_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk ve Son Karakter Yer Değiştirme Uygulamasına Hoş Geldiniz!");

            Console.Write("Bir string ifade girin: ");
            string input = Console.ReadLine();

            string result = SwapFirstAndLastCharacter(input);

            Console.WriteLine("Sonuç: " + result);

            Console.WriteLine("Programı sonlandırmak için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

        // İlk ve son karakteri değiştirme işlemini gerçekleştiren metot
        static string SwapFirstAndLastCharacter(string input)
        {
            if (input.Length <= 1)
                return input;

            char firstChar = input[0];
            char lastChar = input[input.Length - 1];

            string middleChars = input.Substring(1, input.Length - 2);

            return lastChar + middleChars + firstChar;
        }
    }
}
/*Bu program, kullanıcının girdiği string ifade içerisindeki ilk ve son karakteri yer değiştirerek yeni bir string ifade oluşturur. 
Örneğin, "Merhaba Hello Algoritma x" ifadesindeki ilk karakter olan 'M' ile son karakter olan 'x' yer değiştirilerek
yeni bir ifade olan "aerhabM oellH algoritmA x" elde edilir. Program, kullanıcının girdiği string ifadeyi düzenlemek 
ve değiştirmek için kullanılır.*/
