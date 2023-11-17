namespace oppgave_315_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn navnet ditt");
            var inputName = Console.ReadLine();
            for (int i = inputName.Length-1; i >= 0; i--)
            {
                Console.Write($"{inputName[i]}");
            }
        }
    }
}