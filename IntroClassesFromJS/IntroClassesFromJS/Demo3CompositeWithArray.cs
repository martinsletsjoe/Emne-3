using IntroClassesFromJS.V3;

namespace IntroClassesFromJS;

public class Demo3CompositeWithArray
{
    public static void run()
    {
        var model = new Model()
        {
            App = new App()
            {
                CurrentUser = "Martin",
                CurrentPage = "Main"
            },
            People = new Person[]
            {
                new Person
                {
                    FirstName = "Martin",
                    BirthYear = 1995
                }
            },
        };

        //// Alternativ 2 
        //var terje2 = new Person();
        //terje2.FirstName = "Martin";
        //terje2.BirthYear = 1995;
    }
}