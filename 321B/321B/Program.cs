namespace _321B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // opprett array av bil-object
            CarBrands[] cars = new CarBrands[]
            {
                new CarBrands("Toyota", 1990, new string[] {"Land Cruiser", "avensis"}),
                new CarBrands("Mercedes Benz", 1995, new string[] {"300 SL", "E-Class"}),
                new CarBrands("Volvo", 1994, new string[] {"xc70", "240"}),
                new CarBrands("Porsche", 1993, new string[] {"911", "cayman"}),
                new CarBrands("Bmw", 1992, new string[] {"3 Series", "5 Series"}),
                new CarBrands("Alfa Romeo", 1991, new string[] {"gt-v6", "8C"}),
                // Legg til biler
            };

            // Gå gjennom Arrayen og skriv ut informasjon om hver bil
            Console.WriteLine("Enter a car brand");
            while (true)
            {
                Show(cars);
            }
        }

        private static void Show(CarBrands[] cars)
        {
            var userAnswer = Console.ReadLine();
            foreach (CarBrands car in cars)
            {
                if (car.CarBrand.ToLower() == userAnswer.ToLower())
                {
                    Console.WriteLine($"Car Brand: {car.CarBrand}, year {car.Year},");
                    Console.WriteLine("We have these in our inventory: ");
                    for (int i = 0; i < car.CarTypes.Length; i++)
                    {
                        Console.WriteLine(" - "+ car.CarTypes[i]);
                    }
                }
            }
        }
    }
}