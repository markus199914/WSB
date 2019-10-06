using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int liczba;
            Console.WriteLine("podaj liczbe calkowita:");
            str = Console.ReadLine();
            liczba = int.Parse(str);
            if (int.TryParse(str, out liczba) == false)
                Console.WriteLine("zly format liczby");
            else
                Console.WriteLine("liczba wynosi (0)", liczba);
            /*
             * sprawdz czy dane z klawiatury sa 
             * liczba calkowita dodatnia
             * sprawdz czy jest nieparzysta 
             */


            System.Console.WriteLine("Podaj liczbe");
            int liczba1 = int.Parse(Console.ReadLine());
            if (liczba1 % 2 == 0) System.Console.WriteLine("Podana liczba jest parzysta.");
            else System.Console.WriteLine("Podana liczba nie jest parzysta.");
     

            System.Console.WriteLine("Podaj liczbe");
            int liczba2 = int.Parse(Console.ReadLine());
            if (liczba2 > 0 ) System.Console.WriteLine("Podana liczba jest calkowita.");
            else System.Console.WriteLine("Podana liczba nie jest calkowita.");
            Console.ReadKey();
            /* oblicz pole i obwod prostokata sprawdz czy dane sa poprawne w razie bleda musi sie pojawic komunikat
             */

            /* switch
             */

            liczba = 10;
                switch (liczba)
            { 
                case 5:
                    Console.WriteLine("liczba = 5");
                    break;
                case 10:
                    Console.WriteLine("liczba = 10");
                    break;
                case 15:
                    Console.WriteLine("liczba = 15");
                    break;

                default:
                    Console.WriteLine("liczba posiada inna wartosc");
                    break;

            } /*wykorzystaj switch do wyswietlania pochodzenia 
            polska usa hiszpania
            */

            string nar;
            nar = Console.ReadLine();
            switch (nar)
            {
                case "polska":
                Console.WriteLine("kraj = polska");
                    break;
                case "usa":
                    Console.WriteLine("kraj = usa");
                    break;
                case "hiszpania":
                    Console.WriteLine("kraj = hiszpania");
                    break;

                default:
                    Console.WriteLine("liczba posiada inna wartosc");
                    break;
                    int i = 1;
                    for (i - 0; i <= 10; i++)
                    { Console.Write(i + "")
                            } 
            }
            }

        }
    }

}
