using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RomanNumber number = new RomanNumber(9);
                RomanNumber number2 = new RomanNumber(5);
                Console.WriteLine(RomanNumber.Add(number, number2).ToString());
                Console.WriteLine(RomanNumber.Sub(number, number2).ToString());
                Console.WriteLine(RomanNumber.Mul(number, number2).ToString());
                Console.WriteLine(RomanNumber.Div(number, number2).ToString());
            }
            catch (RomanNumberException)
            {
                Console.WriteLine("RomanNumberException");
            }
        }
    }
}
