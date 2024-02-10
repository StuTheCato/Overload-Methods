namespace Ueberladen
{
    internal class Program
    {
        static void AusgabeGanzzahl(int zahl)
        {
            Console.WriteLine($"Die Ganzzahl lautet: {zahl}");
        }

        static void AusgabeDezimal(double wert)
        {
            Console.WriteLine($"Die Dezimalzahl lautet {wert}");
        }

        static void AusgabeText(string text)
        {
            Console.WriteLine($"Der Text lautet: {text}");
        }

        static void Main(string[] args)
        {
            AusgabeGanzzahl(11);
            AusgabeDezimal(3.5);
            AusgabeText("Hello world");

            Console.ReadKey();
        }
    }
}