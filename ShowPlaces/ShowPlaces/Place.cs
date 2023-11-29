namespace ShowPlaces;

public class Place
{
    public string PlaceName { get; private set; }
    public string Municipality { get; private set; }
    public string Region { get; private set; }



    public Place(string placeName, string municipality, string region)
    {
        PlaceName = placeName;
        Municipality = municipality;
        Region = region;

    }


    public void ShowPlace()
    {
        var labelWidth = 9;
        ShowSeparatorRow();
        ShowFieldnameAndValue("Navn", labelWidth, PlaceName);
        ShowFieldnameAndValue("Kommune", labelWidth, Municipality);
        ShowFieldnameAndValue("Fylke", labelWidth, Region);
        ShowSeparatorRow();
    }

    private void ShowFieldnameAndValue(string label, int labelWidth, string fieldValue)
    {
        labelWidth -= label.Length;
        Console.WriteLine(" " + label + ":" + string.Empty.PadLeft(labelWidth) + fieldValue);
    }

    private void ShowSeparatorRow(int labelWidth = 8)
    {
        Console.WriteLine(String.Empty.PadLeft(labelWidth * 3, '*'));
    }
}