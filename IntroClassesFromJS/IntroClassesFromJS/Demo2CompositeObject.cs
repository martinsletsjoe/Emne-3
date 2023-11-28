using IntroClassesFromJS.V2;

namespace IntroClassesFromJS;

public class Demo2CompositeObject
{
    public static void run()
    {
        var model = new Model()
        {
            Person = new Person
            {
                FirstName = "Martin",
                BirthYear = 1995
            }
        };

        //// Alternativ 2 
        //var terje2 = new Person();
        //terje2.FirstName = "Martin";
        //terje2.BirthYear = 1995;
    }
}