using Console = System.Console;

namespace ShowPlaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowSeparatorRow();
            ShowPlace("Stavern", "Larvik", "Vestfold");
            ShowPlace("Lofterød", "Sandefjord", "Vestfold");
        }

        private static void ShowPlace(string place, string municipality, string region)
        {

            var labelWidth = 9;

            ShowFieldnameAndValue("Navn", labelWidth, place);
            ShowFieldnameAndValue("Kommune", labelWidth, municipality);
            ShowFieldnameAndValue("Fylke", labelWidth, region);
            ShowSeparatorRow();
        }

        static void ShowFieldnameAndValue(string label, int labelWidth, string fieldValue)
        {
            labelWidth -= label.Length;
            Console.WriteLine(" " + label + ":" +string.Empty.PadLeft(labelWidth) + fieldValue);
        }

        static void ShowSeparatorRow(int labelWidth = 8)
        {
            Console.WriteLine(String.Empty.PadLeft(labelWidth*3, '*'));
        }
    }
}