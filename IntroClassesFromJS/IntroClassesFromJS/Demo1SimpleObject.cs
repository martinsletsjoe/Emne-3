namespace IntroClassesFromJS;

    internal class Demo1SimpleObject
    {
        public static void run()
        {
            // Alternativ 1 
            var terje1 = new Person
            {
                FirstName = "Martin",
                BirthYear = 1995
            };
            Console.WriteLine(terje1.FirstName);

            // Alternativ 2 
            var terje2 = new Person();
            terje2.FirstName = "Martin";
            terje2.BirthYear = 1995;
        }
    }