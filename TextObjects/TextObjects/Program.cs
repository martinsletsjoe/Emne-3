namespace TextObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myText = new TextEffect();
            //myText.Text = "Hello";
            var myText = new TextEffect()
            {
                Text = "Hallo",
                Color = ConsoleColor.Red,
                Col = 3,
                Row = 10, 
                IsInverted = false,
                Case = Case.Default,

            };
        }
    }
}

/* 
let texts = [
   {
   text: 'Hallo',
   color: 'red',
   col: 3,
   rad: 10,
   isInverted: false,
   case: null,
   },
   ]
*/