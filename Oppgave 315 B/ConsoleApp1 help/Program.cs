var range = 250;
var counts = new int[range];
string text = "something";

while(!string.IsNullOrWhiteSpace(text))
    for (int i = 0; i < text.Length; i++)
    {
        counts[text[i]]++;
        if (counts[text[i]] > 0)
        {
            var character = (char)i;
            Console.WriteLine($"{character} - {counts[i]}");
        }
    }