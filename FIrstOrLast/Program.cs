using System;

namespace FIrstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada ees- ja perekonnanime;
            //programm kontroll andmete pikkust (eraldi);
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi;
            //if'iga hiljem kas sama pikk v kumb on pikem;
            //küsi algul eesnimi ja seejärel perekonnanimi;

            Console.WriteLine("Palun, sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Palun, sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes on {lastName.Length} sümbolit.");

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi, kuna sisaldab rohkem sümboleid.");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi, kuna sisaldab rohkem sümboleid.");
            }
            else
            {
                Console.WriteLine("Eesnimi ja perekonnanimi on sama pikad.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
