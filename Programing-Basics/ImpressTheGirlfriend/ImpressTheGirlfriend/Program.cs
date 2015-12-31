using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressTheGirlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal rublesRate=3.5m/100;
            const decimal dollarsRate=1.5m;
            const decimal euroRate = 1.95m;

            decimal rubles = decimal.Parse(Console.ReadLine());
            decimal dollars = decimal.Parse(Console.ReadLine());
            decimal euro = decimal.Parse(Console.ReadLine());
            decimal levaSpecial = decimal.Parse(Console.ReadLine());
            decimal leva = decimal.Parse(Console.ReadLine());

            decimal mostExpensivePrice;

            decimal priceInRubles = rubles * rublesRate;

            mostExpensivePrice = priceInRubles;

            decimal priceInDollars = dollars * dollarsRate;

            mostExpensivePrice=CalculateMostExensive(mostExpensivePrice, priceInDollars);

            decimal priceInEuro = euro * euroRate;

            mostExpensivePrice=CalculateMostExensive(mostExpensivePrice, priceInEuro);

            decimal priceInLevaSpecialOffer = levaSpecial - levaSpecial / 2;

            mostExpensivePrice=CalculateMostExensive(mostExpensivePrice, priceInLevaSpecialOffer);

            decimal priceInLevaStandart=leva;

            mostExpensivePrice=CalculateMostExensive(mostExpensivePrice, priceInLevaStandart);

            Console.WriteLine("{0:0.00}",Math.Ceiling(mostExpensivePrice));


        }

        public static decimal CalculateMostExensive(decimal mostExpensivePrice, decimal currentPrice)
        {

            if (mostExpensivePrice<currentPrice)
            {
                return currentPrice;
            }

            return mostExpensivePrice;
        }
    }
}
