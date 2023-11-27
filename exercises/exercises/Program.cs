using exercises;
using System.Linq;

//Clicker.Run();

var clickers = new Clicker[]
{
    new Clicker { _letter = 'a' },
    new Clicker { _letter = 'b' },
    new Clicker { _letter = 'c' },
};


while (true)
{
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.Show();
    }
    var inputKey = Console.ReadKey(true);
    foreach (var clicker in clickers)
    {
        clicker.Count(inputKey.KeyChar);
    }

}










