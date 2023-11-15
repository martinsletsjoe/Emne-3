using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenPwd
{
    class Program
    {
        static Random _random = new Random();

        public static void Main(string[] args)
        {
            if (args.Length != 2
                || !IsValidNumber(args[0])
                || !IsValidPattern(args[1]))
            {
                ShowInstructionsAndQuit();
            }
            var length = Convert.ToInt32(args[0]);
            var pattern = args[1].PadRight(length, 'l');
            var password = "";
            foreach (var letter in pattern)
            {
                if (letter == 'l') password += WriteRandomLowerCaseLetter();
                else if (letter == 'L') password += WriteRandomUpperCaseLetter();
                else if (letter == 'd') password += WriteRandomDigit();
                else if (letter == 's') password += WriteRandomSpecialCharacter();
            }

            var newPassword = randomisePassword(password);
            Console.WriteLine(password);
            Console.WriteLine(newPassword);
        }

        private static char WriteRandomSpecialCharacter()
        {
            return GetRandomCharacter("(!\"#\u00a4%&/(){}[]");
        }

        private static char WriteRandomDigit()
        {
            var codeFor0 = (int)'0';
            var character = (char)(_random.Next(0, 9) + codeFor0);
            return character;
        }

        private static char WriteRandomUpperCaseLetter()
        {
            return GetRandomCharacter("ABCDEFGHIJKLMOPQRSTUVWXYZÆØÅ");
        }

        private static char WriteRandomLowerCaseLetter()
        {
            return GetRandomCharacter("abcdefghijklmopqrstuvwxyzæøå");
        }

        static string randomisePassword(string password)
        {
            char[] charArray = password.ToCharArray();
            Random random = new Random();

            for (int i = charArray.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);
                char temp = charArray[i];
                charArray[i] = charArray[randomIndex];
                charArray[randomIndex] = temp;
            }

            return new string(charArray);
        }

        private static char GetRandomCharacter(string allChars)
        {
            var index = _random.Next(0, allChars.Length - 1);
            var character = allChars[index];
            return character;
        }

        private static bool IsValidPattern(string pattern)
        {
            foreach (var letter in pattern)
            {
                if (!"lLsd".Contains(letter)) return false;
            }
            return true;
        }

        static bool IsValidNumber(string number)
        {
            foreach (var digit in number)
            {
                if (!char.IsDigit(digit)) return false;
            }
            return true;
        }

        private static void ShowInstructionsAndQuit()
        {
            Console.WriteLine(@"PasswordGenerator  
Options:
- l = liten bokstav
- L = stor bokstav
- d = siffer
- s = spesialtegn (!""#¤%&/(){}[]
Eksempel: PasswordGenerator 14 lLssdd
    betyr
        Min. 1 liten bokstav
        Min. 1 1 stor bokstav
        Min. 2 spesialtegn
        Min. 2 sifre
        Lengde på passordet skal være 14");
            Environment.Exit(0);
        }
    }

    /*
            Console.WriteLine($"Det er {args.Length} parametre.");
       if (args.Length == 0) return;
       for (var i = 0; i < args.Length; i++)
       {
       Console.WriteLine($"Parameter {i+1} har verdien {args[i]}");
       }
       return;
            

            //var isSuccess = int.TryParse(args[0], out int length);
       
     */
}