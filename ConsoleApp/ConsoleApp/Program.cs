using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var sklad = new List<string>() {"Нью-Йоркский", "Лондонский"};
            string newYork = sklad[0];
            string london = sklad[1];


            List<Products> cofe = new List<Products>()
            {
                new Products(newYork, "Апельсин", 160, 0),
                new Products(london, "Арбуз", 0, 0.4),
                new Products(london, "Ананас", 0, 0.3),
                new Products(london, "Груша", 500, 0),
                new Products(newYork, "Груша", 980, 0)
            };


            var sortedName = from n in cofe
                orderby n.Name
                select n;

            Console.WriteLine("Полка товаров: ");

            foreach (var n in sortedName)
            {
                Regex regex = new Regex(@"А(\w*)");
                MatchCollection matches = regex.Matches(n.Name);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        if ((n.Remainder = n.Ton * 1000) < 500 && n.Remainder != 0)
                        {
                            Console.WriteLine($"{n.Warehouses} - {match.Value} Остаток:  {n.Remainder} кг");
                        }

                        if (n.Klgm < 500 && n.Klgm != 0)
                        {
                            Console.WriteLine($"{n.Warehouses} - {match.Value} Остаток:  {n.Klgm} кг");
                        }
                    }
                }
            }
        }
    }
}