using System;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine();
            if (int.TryParse(Console.ReadLine(), out int y))
            {
                if (y != 0)
                {
                    int rezultat = x / y;
                    int rest = x % y;
                    Console.WriteLine($"Rezultatul impartirii este {rezultat}");
                    Console.WriteLine($"Restul impartirii este {rest}");
                }
                else
                {
                    Console.WriteLine("Impartirea la 0 nu este posibila.");
                }
            }
            else
            {
                Console.WriteLine("Al doilea numar nu este valid.");
            }
        }
        else
        {
            Console.WriteLine("Primul numar nu este valid.");
        }
    }
}
