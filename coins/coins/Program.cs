

//static void show(){
//var numbersAndStuff = Class1.Calculate();
//Console.WriteLine(numbersAndStuff);
//}

namespace coins;

internal class Program
{
    public static void Main(string[] args)
    {
        var coinCounter = new Class1();
        Console.WriteLine("Skriv hvor mange du har");
        var userInput = Console.ReadLine();
        var userInputInt = Convert.ToInt32(userInput);
        coinCounter.Calculate(userInputInt);
        var answer = Console.ReadLine();
    }
}