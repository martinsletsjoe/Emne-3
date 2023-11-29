namespace _321B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // opprett array av bil-object
            CarBrands[] cars = new CarBrands[]
            {
                new CarBrands("Toyota", 1990),
                new CarBrands("Mercedes Benz", 1995),
                new CarBrands("Volvo", 1994),
                new CarBrands("Porsche", 1993),
                new CarBrands("Bmw", 1992),
                new CarBrands("Alfa Romeo", 1991),
                // Legg til biler
            };

            // Gå gjennom Arrayen og skriv ut informasjon om hver bil
            foreach (CarBrands car in cars)
            {
                Console.WriteLine(car.CarBrand);
            }

        }

        //private static CarBrands[] CarArray()
        //{

        //    return car;
        //}
    }
}
//public class CarBrands
//{
//    public string CarBrand { get; set; }
//    public int Year { get; set; }


//    public CarBrands(string carBrand, int year)
//    {
//        carBrand = carBrand;
//        year = year;
//    }
//}
