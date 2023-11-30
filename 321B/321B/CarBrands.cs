namespace _321B;

public class CarBrands
{
    public string CarBrand { get; private set; }
    public int Year { get; private set; }
    public string[] CarTypes { get; private set; }


    public CarBrands(string carBrand, int year, string[] carTypes)
    {
        CarBrand = carBrand;
        Year = year;
        CarTypes = carTypes;
    }
}
