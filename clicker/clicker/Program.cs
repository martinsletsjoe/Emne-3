namespace clicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is not ["+" or "0"])
            {
                Console.WriteLine("Angi + for klikk eller 0 for oppgradering");
                return;
            }



            var filename = "clickerdata.txt";
            int points;
            int pointsPerClick;

            if (!File.Exists(filename))
            {
                points = 0;
                pointsPerClick = 1;
            }
            else
            {
                var data = File.ReadAllLines(filename);
                points = Convert.ToInt32(data[0]);
                pointsPerClick = Convert.ToInt32(data[1]);
            }
            var isClick = args[0] == "+";
            if (isClick)
            {
                points += pointsPerClick;
            }
            else if (points >= 10) 
            {
                points -= 10;
                pointsPerClick++;
                
            }

            Console.WriteLine($"{points} poeng");

            File.WriteAllText(filename, points + "\n" + pointsPerClick);
        }
    }
}

// Video avsluttet fra 15:16