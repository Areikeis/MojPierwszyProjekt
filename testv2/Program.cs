using System;

namespace testv2
{
    // jezeli wpisze aa -> app exploduje
    // jezeli wpisze 0.2 -> app exploduje

    class Program
    {
        private static bool runShow = true;
        static void Main(string[] args)
        {
            while (runShow)
            {
                var number1 = GetNumber();
                var number2 = GetNumber();

                Console.WriteLine($"Twoje liczby to: {number1} {number2}");

                if (number1 > number2)
                {
                    Console.WriteLine($"Liczba pierwsza jest większa od drugiej o {number1 - number2}");
                }
                else if (number1 < number2)
                {
                    Console.WriteLine($"Liczba druga jest większa od pierwszej o {number2 - number1}");
                }
                else if (number1 == number2)
                {
                    Console.WriteLine("Obie liczby są równe");
                }

                Console.WriteLine("Enter to run again");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
                if (keyInfo.Key != ConsoleKey.Enter)
                {
                    runShow = false;
                }
            }
        }

        private static double GetNumber()
        {
            while (true)
            {
                Console.WriteLine("Please input number: ");
                var line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line) && double.TryParse(line, out var number))
                {
                    return number;
                }
                Console.WriteLine("Incorrect number");
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
