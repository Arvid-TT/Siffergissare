using System;

namespace Nummergissare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal mellan 1 och 100");
            Random slump = new Random();
            int tal = slump.Next(100);
            int antal = 1;
            int gissning;
            while (true)
            {
                gissning = int.Parse(Console.ReadLine());
                if (tal == gissning)
                {
                    Console.WriteLine("Grattis, du gissade rätt. Talet var " + tal + ".");
                    Console.WriteLine("Det to dig " + antal + " försök att gissa rätt.");
                    break;
                }
                else if (tal > gissning)
                {
                    Console.WriteLine("Du gissade för lågt, försök igen!");
                }
                else if (tal < gissning)
                {
                    Console.WriteLine("Du gissade för högt, försök igen!");
                }
                antal++;
            }
        }
    }
}