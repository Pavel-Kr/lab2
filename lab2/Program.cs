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
                Console.WriteLine("\n");
                RomanNumber number3 = new RomanNumber(11);
                RomanNumber[] numbers = { number, number2, number3 };
                Array.Sort(numbers);
                foreach(RomanNumber i in numbers)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch (RomanNumberException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
