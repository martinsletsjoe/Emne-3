namespace Colors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var color = new Color();

            while (true)
            {
                color.SetColors();
                Console.Clear();
                Dictionary<string, Action<Color>> actions = new Dictionary<string, Action<Color>>                {
                    {"1", c => c.ToLight()},
                    {"2", c => c.ToDark()},
                    {"3", c => c.InvertColor()},
                    {"4", c => c.NextColor()},
                    {"5", c => c.PrevColor()},
                };
                Console.WriteLine("Farge: " + color.TheColor);
                Console.WriteLine("Hva vil du gjøre? ");
                Console.WriteLine(" 1 = gå fra mørk til lys");
                Console.WriteLine(" 2 = gå fra lys til mørk");
                Console.WriteLine(" 3 = inverter ");
                Console.WriteLine(" 4 = neste ");
                Console.WriteLine(" 5 = forrige ");

                var cmd = Console.ReadLine();
                if (actions.ContainsKey(cmd))
                {
                    actions[cmd](color);
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }

            /*
               Black = 0,
               DarkBlue = 1,
               DarkGreen = 2,
               DarkCyan = 3,
               DarkRed = 4,
               DarkMagenta = 5,
               DarkYellow = 6,
               Gray = 7,
               DarkGray = 8,
               Blue = 9,
               Green = 10,
               Cyan = 11,
               Red = 12,
               Magenta = 13,
               Yellow = 14,
               White = 15
             */
        }
    }
}