using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            DaireCizici daireCizici = new DaireCizici();
            daireCizici.DaireCiz(yaricap);

            Console.ReadLine();
        }
    }

    class DaireCizici
    {
        public void DaireCiz(double yaricap)
        {
            double daireCevresi = 2 * Math.PI * yaricap;
            double daireAlanı = Math.PI * yaricap * yaricap;

            Console.WriteLine("Daire Çizildi!");
            Console.WriteLine($"Yarıçap: {yaricap}");
            Console.WriteLine($"Çevre: {daireCevresi}");
            Console.WriteLine($"Alan: {daireAlanı}");
        }
    }
}