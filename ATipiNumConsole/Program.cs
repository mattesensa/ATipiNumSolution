using System;

namespace ATipiNumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo di cui calcolare lo sconto");
            double prezzoIntero = Convert.ToDouble(Console.ReadLine());
            int sconto = 10;
            decimal prezzoFinale;

            Console.WriteLine($"Prezzo iniziale: {prezzoIntero} ");
            for (int i = 1; i < 10; i++)
            {
                prezzoFinale = Convert.ToDecimal(prezzoIntero - (prezzoIntero / 100 * sconto));
                Console.WriteLine($"sconto {i}0% ->Prezzo scontato {prezzoFinale}");
                sconto += 10;
            }



        }
    }
}
