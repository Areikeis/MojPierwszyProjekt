using System;

namespace testv2
{
    // jezeli wpisze aa -> app exploduje
    // jezeli wpisze 0.2 -> app exploduje

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pierwsza liczba");
            int liczba1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Druga liczba");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Twoje liczby to: " + $"{liczba1} {liczba2}");

            if (liczba1 > liczba2)
            {
                int roznica = liczba1 - liczba2;
                Console.WriteLine("Liczba pierwsza jest większa od drugiej o " + roznica);
            }
            else if (liczba1 < liczba2)
            {
                int roznica = liczba2 - liczba1;
                Console.WriteLine("Liczba druga jest większa od pierwszej o " + roznica);
            }
            else if (liczba1 == liczba2)
            {
                Console.WriteLine("Obie liczby są równe");
            }
            
        }
    }
}
