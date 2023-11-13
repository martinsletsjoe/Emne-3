namespace JS2CS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");


            var birthYear = MyConsole.AskForInt("I hvilket år ble du født?");
            var hadbirthDay = MyConsole.AskForBool("Har du hatt bursdag i år?");
            var age = 2023 - birthYear;
            if (!hadbirthDay) age--;
            Console.WriteLine($"Da er du {age}år gammel.");


            //var issuccess = true;
            //var n = 0;
            //var c = 'c';
            //var s = "martin";

            //bool issuccess = true;
            //int n = 0;
            //char c = 'c';
            //string s = "martin";
        }
    }
}