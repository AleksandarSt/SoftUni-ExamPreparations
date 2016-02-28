using System;
using System.Numerics;
using System.Text;

namespace Softuni_Numerals
{
    class SoftuniNumerals
    {
        static void Main()
        {
            const string zero = "aa";
            const string one = "aba";
            const string two = "bcc";
            const string three = "cc";
            const string four = "cdc";
            string line = Console.ReadLine();

            StringBuilder currentLine=new StringBuilder();
            currentLine.Append(line);
            StringBuilder numberInSoftUniNumeral=new StringBuilder();

            do
            {
                if (currentLine.ToString().Substring(0, zero.Length) == zero)
                {
                    numberInSoftUniNumeral.Insert(numberInSoftUniNumeral.Length, 0);
                    currentLine.Remove(0, zero.Length);
                }
                else if (currentLine.ToString().Substring(0, one.Length) == one)
                {
                    numberInSoftUniNumeral.Insert(numberInSoftUniNumeral.Length, 1);
                    currentLine.Remove(0, one.Length);
                }
                else if (currentLine.ToString().Substring(0, two.Length) == two)
                {
                    numberInSoftUniNumeral.Insert(numberInSoftUniNumeral.Length, 2);
                    currentLine.Remove(0, two.Length);
                }
                else if (currentLine.ToString().Substring(0, three.Length) == three)
                {
                    numberInSoftUniNumeral.Insert(numberInSoftUniNumeral.Length, 3);
                    currentLine.Remove(0, three.Length);
                }
                else if (currentLine.ToString().Substring(0, four.Length) == four)
                {
                    numberInSoftUniNumeral.Insert(numberInSoftUniNumeral.Length, 4);
                    currentLine.Remove(0, four.Length);
                }
            } while (currentLine.Length != 0);

            BigInteger numberInDecimal = 0;
            BigInteger numberInSoftUniNumeralInt = BigInteger.Parse(numberInSoftUniNumeral.ToString());

            for (int pow = 0; pow < numberInSoftUniNumeral.Length; pow++)
            {
                //numberInDecimal = numberInDecimal + (numberInSoftUniNumeralInt % 10) * CalculatePowOfFive(pow);
                numberInDecimal = numberInDecimal + (numberInSoftUniNumeralInt % 10) * BigInteger.Pow(5,pow);
                numberInSoftUniNumeralInt = numberInSoftUniNumeralInt/10;
            }

            Console.WriteLine(numberInDecimal);
        }

        public static BigInteger CalculatePowOfFive(int pow)
        {
            BigInteger result = 1;//5^0

            for (int i = 1; i <= pow; i++)
            {
                result = result*5;
            }
            return result;
        }
    }
}
