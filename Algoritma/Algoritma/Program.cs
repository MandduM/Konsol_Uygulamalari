using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifadeyi girin: ");
            string ifade = Console.ReadLine();

            Console.Write("İndex numarasını girin: ");
            int index = Convert.ToInt32(Console.ReadLine());

            KarakterCikarici karakterCikarici = new KarakterCikarici();
            karakterCikarici.KarakterCikar(ifade, index);

            Console.ReadLine();
        }
    }

    class KarakterCikarici
    {
        public void KarakterCikar(string ifade, int index)
        {
            if (index >= 0 && index < ifade.Length)
            {
                string yeniIfade = ifade.Remove(index, 1);
                Console.WriteLine($"Yeni ifade: {yeniIfade}");
            }
            else
            {
                Console.WriteLine("Geçersiz index numarası!");
            }
        }
    }
}
    