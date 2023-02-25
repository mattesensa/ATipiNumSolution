using System;

namespace ATipiNumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            float prezzoIntero = 100.0F;
            float sconto = 0.1F;
            float prezzoFinale = 0;

            Console.WriteLine($"FLOAT Prezzo iniziale: {prezzoIntero} ");
            for (int i = 1; i < 10; i++)
            {
                prezzoFinale = prezzoIntero * (1 - i * sconto);
                Console.WriteLine($"sconto {i}0% ->Prezzo scontato {prezzoFinale} ");
            }



        }
    }
}
