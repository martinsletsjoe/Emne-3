using Console = System.Console;

namespace Oppgave_315_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PasswordGenerator");
            Console.WriteLine("Options");
            string[] passwordCriteria =
                { "l = liten bokstav", "L = stor bokstav", "d = siffer", "s = spesialtegn (!\"#%¤&/(){}[]" };
            foreach (var character in passwordCriteria)
            {
                Console.WriteLine($"- {character}");
            }

            Console.WriteLine($"Eksempel: PasswordGenerator 14 lLssd");
            Console.WriteLine("     betyr");
            string[] explanation = { "1 liten bokstav", "1 stor bokstav", "2 spesialtegn", "2 sifre" };
            foreach (var VARIABLE in explanation)
            {
                Console.WriteLine($"Min. {VARIABLE}");
            }

            Console.WriteLine($"Lengde på passordet skal være 14 tegn.");
            Console.Write("Skriv inn ønsket lengde:");
            string amountInput = Console.ReadLine();
            foreach (var c in amountInput)
            {
                if (!char.IsDigit(c))
                {
                    Console.WriteLine("ugyldig, kun tall er gyldig");
                }
            }

            Console.WriteLine("Hvilken egenskaper ønsker du at passordet skal ha?");
            string typeInput = Console.ReadLine();
            foreach (var c in typeInput)
            {

            }
            {
                
            }
            {
                
            }
        }
    }
}
//Console.WriteLine("Enter length of password");
//string amountInput = Console.ReadLine();
//int amount = int.Parse(amountInput);

//Console.WriteLine("Enter password criteria");
//string type = Console.ReadLine();