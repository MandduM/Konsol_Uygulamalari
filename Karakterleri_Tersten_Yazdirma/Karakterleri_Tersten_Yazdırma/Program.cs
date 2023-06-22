using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakterleri_Tersten_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi girin: ");
            string ifade = Console.ReadLine();

            KarakterYerDegistirici karakterYerDegistirici = new KarakterYerDegistirici();
            string yeniIfade = karakterYerDegistirici.KarakterYerDegistir(ifade);

            Console.WriteLine($"Yeni ifade: {yeniIfade}");
            Console.ReadLine();
        }
    }

    class KarakterYerDegistirici
    {
        public string KarakterYerDegistir(string ifade)
        {
            char[] karakterler = ifade.ToCharArray();

            for (int i = 1; i < karakterler.Length; i++)
            {
                char temp = karakterler[i];
                karakterler[i] = karakterler[i - 1];
                karakterler[i - 1] = temp;
            }

            return new string(karakterler);
        }
    }
}