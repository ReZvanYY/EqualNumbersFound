using System.ComponentModel;

namespace OnePlusOneEqualsMaybeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            var setNumber = number.Next(0, 11);


            Console.WriteLine("Give me the first number between 0 and 10, please!");
            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me the second number between 0 and 10, please!");
            var numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne != numberTwo)
            {
                Console.WriteLine("The answer is:" + AddUnEquals(numberOne, numberTwo));
            }
            else if (numberOne == numberTwo)
            {
                Console.WriteLine("The answer is:" + MultiplyEquals(numberOne, numberTwo));
            }
        }

        static int AddUnEquals(int NumberOne, int NumberTwo)
        {
            return NumberOne + NumberTwo;

        }
        static int MultiplyEquals(int NumberOne, int NumberTwo)
        {
            return NumberOne * NumberTwo;

        }
    }

}