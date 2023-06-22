using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Üçgenin boyutunu girin: ");
                int boyut = Convert.ToInt32(Console.ReadLine());

                UcgenCizici ucgenCizici = new UcgenCizici();
                ucgenCizici.UcgenCiz(boyut);

                Console.ReadLine();
            }
        }

        class UcgenCizici
        {
            public void UcgenCiz(int boyut)
            {
                for (int i = 1; i <= boyut; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
