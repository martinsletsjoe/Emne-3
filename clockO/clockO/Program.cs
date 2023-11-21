using System;
using clockO;

namespace Watch
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var myTexts = new TextEffect();




            Console.WindowWidth = 200;
            while (true)
            {

                Timer(60, DateTime.Now.Second, "Seconds");
                Timer(60, DateTime.Now.Minute, "Minute");
                Timer(24, DateTime.Now.Hour, "Hour");
                // Mulig å sende et object som inneholder både timeunit og timetitle?



                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        private static void Timer(int timeUnits, int typeClock, string timeTitle)
        {
            int secondsNow = typeClock;

            Console.WriteLine(timeTitle);
            Console.WriteLine("*".PadLeft(3 * secondsNow, ' '));


            for (int seconds = 1; seconds <= timeUnits; seconds++)
            {
                Console.Write(seconds.ToString().PadLeft(3, ' '));
            }

            Console.WriteLine(' ');
        }
    }
}


/*                //var minutesNow = DateTime.Now.Minute;
   //Console.WriteLine("*".PadLeft(3 * minutesNow, ' '));
   //for (int minutes = 1; minutes <= 60; minutes++)
   //{
   //    Console.Write(minutes.ToString().PadLeft(3, ' '));
   //}
   
   //Console.WriteLine(' ');
   
   //var hoursNow = DateTime.Now.Hour;
   //Console.WriteLine("*".PadLeft(3 * hoursNow, ' '));
   //for (int hours = 1; hours <= 24; hours++)
   //{
   //    Console.Write(hours.ToString().PadLeft(3, ' '));
   
   //}
*/