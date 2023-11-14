var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine().ToLower() ?? string.Empty;
    for (int i = 0; i < text.Length; i++)
        //foreach (var character in text ?? string.Empty)
    {
        counts[text[i]]++;
        //counts[character]++;
        //Console.WriteLine(counts[text[i]]);

        if (counts[text[i]] > 0)
        {
            var character = text[i];
            Console.WriteLine(character + " - " + counts[text[i]]);
        }
    }
}asd