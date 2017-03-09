using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Podaj 2 liczby");
            double liczba1;
          double liczba2;
             liczba1 = double.Parse(Console.ReadLine());
             liczba2 = double.Parse(Console.ReadLine());

             Console.WriteLine("Co zrobić z liczbami? 1 - dodawanie, 2 - odejmowanie, 3- mnożenie, 4- dzielenie");
            int choise;
           double wynik;

            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    wynik = (liczba1 + liczba2);
                    Console.WriteLine("Wynik: ");
                    Console.WriteLine(wynik);
                    break;
                case 2:
                    wynik = (liczba1 - liczba2);
                    Console.WriteLine("Wynik: ");
                    Console.WriteLine(wynik);
                    break;
                case 3:
                    wynik = (liczba1 * liczba2);
                    Console.WriteLine("Wynik: " );
                    Console.WriteLine(wynik);
                    break;
                case 4:
                    wynik = (liczba1 / liczba2);
                    Console.WriteLine("Wynik: ") ;
                    Console.WriteLine(wynik);

                    break;
                default:
                    Console.WriteLine("Nie wybrałeś numeru");
                    break;

            }
            Console.ReadKey();
        }
    }
}
