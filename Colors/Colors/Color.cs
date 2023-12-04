using System.Drawing;

namespace Colors;

public class Color
{
    private ConsoleColor _color;

    public Color()
    {
        _color = ConsoleColor.Green;
    }

    public ConsoleColor GetCurrentColor()
    {
        return _color;
    }

    public void SetColors()
    {
        Console.BackgroundColor = _color;
        Console.ForegroundColor = (ConsoleColor)(15 - (int)_color);
    }

    public void ToLight()
    {
        var colorName = _color.ToString();
        if (colorName.Contains("Dark"))
        {
            colorName = colorName.Substring(4);
            _color = Enum.Parse<ConsoleColor>(colorName);
        }
    }

    public void ToDark()
    {
        var colorName = _color.ToString();  
        colorName = "Dark" + colorName;
        var isSuccess = ConsoleColor.TryParse(colorName, out _color);
    }

    public void InvertColor()
    {
        var colorNumber = (int)_color;
        colorNumber = 15 - colorNumber;
        _color = (ConsoleColor)colorNumber;
    }

    public void NextColor()
    {
        if ((_color == ConsoleColor.White))
        {
            _color = ConsoleColor.Black;
        }
        else
        {
            _color++;
        }
        
    }

    public void PrevColor()
    {
        if (_color == ConsoleColor.Black)
        {
            _color = ConsoleColor.White;
        }
        else
        {
            _color--;
        }
    }
}