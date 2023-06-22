using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    abstract class Hesaplayici
    {
        protected double[] Kenarlar { get; set; }

        public abstract double Hesapla();
    }

    class DaireHesaplayici : Hesaplayici
    {
        public DaireHesaplayici()
        {
            Kenarlar = new double[1];
            Console.Write("Dairenin yarıçapını girin: ");
            Kenarlar[0] = Convert.ToDouble(Console.ReadLine());
        }

        public override double Hesapla()
        {
            double yaricap = Kenarlar[0];
            return 2 * Math.PI * yaricap;
        }
    }

    class UcgenHesaplayici : Hesaplayici
    {
        public UcgenHesaplayici()
        {
            Kenarlar = new double[3];
            Console.Write("Üçgenin kenar uzunluklarını girin (a, b, c): ");
            for (int i = 0; i < 3; i++)
            {
                Kenarlar[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public override double Hesapla()
        {
            double a = Kenarlar[0];
            double b = Kenarlar[1];
            double c = Kenarlar[2];

            double u = (a + b + c) / 2;
            return Math.Sqrt(u * (u - a) * (u - b) * (u - c));
        }
    }

    class KareHesaplayici : Hesaplayici
    {
        public KareHesaplayici()
        {
            Kenarlar = new double[1];
            Console.Write("Karenin kenar uzunluğunu girin: ");
            Kenarlar[0] = Convert.ToDouble(Console.ReadLine());
        }

        public override double Hesapla()
        {
            double kenar = Kenarlar[0];
            return kenar * kenar;
        }
    }

    class DikdortgenHesaplayici : Hesaplayici
    {
        public DikdortgenHesaplayici()
        {
            Kenarlar = new double[2];
            Console.Write("Dikdörtgenin kısa kenarını girin: ");
            Kenarlar[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dikdörtgenin uzun kenarını girin: ");
            Kenarlar[1] = Convert.ToDouble(Console.ReadLine());
        }

        public override double Hesapla()
        {
            double kisaKenar = Kenarlar[0];
            double uzunKenar = Kenarlar[1];
            return kisaKenar * uzunKenar;
        }
    }
}