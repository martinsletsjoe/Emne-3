using System.Drawing;

namespace Colors;

public class Color
{
    public ConsoleColor TheColor { get; private set; }

    public Color()
    {
        TheColor = ConsoleColor.Green;
    }

    public ConsoleColor GetCurrentColor()
    {
        return TheColor;
    }

    public void SetColors()
    {
        Console.BackgroundColor = TheColor;
        Console.ForegroundColor = (ConsoleColor)(15 - (int)TheColor);
    }

    public void ToLight()
    {
        var colorName = TheColor.ToString();
        if (colorName.Contains("Dark"))
        {
            colorName = colorName.Substring(4);
            TheColor = Enum.Parse<ConsoleColor>(colorName);
        }
    }

    public void ToDark()
    {
        var colorName = TheColor.ToString();  
        colorName = "Dark" + colorName;
        var isSuccess = ConsoleColor.TryParse(colorName, out ConsoleColor color);
        if (isSuccess)
        {
            TheColor = color;
        }
    }

    public void InvertColor()
    {
        var colorNumber = (int)TheColor;
        colorNumber = 15 - colorNumber;
        TheColor = (ConsoleColor)colorNumber;
    }

    public void NextColor()
    {
        if ((TheColor == ConsoleColor.White))
        {
            TheColor = ConsoleColor.Black;
        }
        else
        {
            TheColor++;
        }
        
    }

    public void PrevColor()
    {
        if (TheColor == ConsoleColor.Black)
        {
            TheColor = ConsoleColor.White;
        }
        else
        {
            TheColor--;
        }
    }
}