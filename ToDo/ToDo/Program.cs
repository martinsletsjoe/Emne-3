using System.ComponentModel;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myTasks = modelData();
            while (true)
            {
                Console.Clear();
                Show(myTasks);

                AskUserForTask(myTasks);
            }
        }

        private static void AskUserForTask(List<Task> myTasks)
        {
            Console.WriteLine("Vil du legge til fler?");
            Console.WriteLine("1 = Legg til ny");
            Console.WriteLine("2 = Marker fullført");

            var userInput = Console.ReadLine();
            if (userInput == "1")
            {
                var newTask = new Task();
                Console.WriteLine("Beskriv oppgaven");
                newTask.text = Console.ReadLine();
                Console.WriteLine("Når skal den være ferdig? (dd/mm/yyyy");
                newTask.DueTime = Convert.ToDateTime(Console.ReadLine());
                myTasks.Add(newTask);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Skriv nr til oppgaven du ønsker å markere som ferdig");
                var markedTask = Console.ReadLine();
                myTasks[int.Parse(markedTask) - 1].IsDone = true;
            }
        }

        // single resonsibility principle

        static void Show(List<Task> myTasks)
        {
            Console.WriteLine("To Do List ");
            Console.WriteLine(" Dagens dato: " + DateTime.Now + "\n");

            foreach (var task in myTasks)
            {
                Console.WriteLine(task.text);
                var timeOfDay = task.DueTime.TimeOfDay;

                var taskDue = task.DueTime.ToString();


                if (timeOfDay == TimeSpan.Zero)
                {
                    taskDue = task.DueTime.ToString("dd MM yyyy");
                }
                Console.Write(" - " + task.text);
                Console.WriteLine(" Frist: " + taskDue);
                Console.WriteLine(task.IsDone ? $"   Oppgaven ble fullført {task.CompletionDate}" : "   Oppgaven er uferdig");
                //Console.WriteLine("Er oppgaven fullført? "+ myTasks.Completed ? "ja": "nei");
                Console.WriteLine();
            }
        }

        static List<Task> modelData()
        {
            var myText = new List<Task>
            {
                new Task()
                {
                    text = "Vask bil",
                    DueTime = new DateTime(2023, 11, 22),
                    IsDone = true,
                    CompletionDate = new DateTime(2023, 11, 15, 14, 30, 0),
        },
                new Task()
                {
                    text = "Gå tur med hund",
                    DueTime = new DateTime(2023, 12, 22),
                    IsDone = false,
                    CompletionDate = new DateTime(2023, 11, 14, 15, 23, 00),
        },
                new Task()
                {
                    text = "Støvsuge",
                    DueTime = new DateTime(2023, 11, 22),
                    IsDone = true,
                    CompletionDate = new DateTime(2023, 11, 14, 02, 03, 40),
        },
            };
            return myText;
        }


    }
}


/*
 Lag en enkel todo-app med objekter. Hver oppgave har en tekst, en DueTime (dato, les dere opp på DateTime),
og om den er gjort eller ikke  + dato når den ble gjort. Lag en liste av oppgaver og kode som viser dem på en pen måte. 
La brukeren velge fra en meny: legg til ny eller marker som gjort.
*/

/*                     if (myText3.text != null)
   {
   drawList(myText3);
   }
   myText3.text = Console.ReadLine();
   Console.WriteLine("Når er fristen?");
   myText3.DueTime = Convert.ToDateTime(Console.ReadLine());
   Console.WriteLine("Skriv ja om ferdig eller nei om du enda holder på");
   var isCompleted = Console.ReadLine();
   if (isCompleted == "ja")
   {
   myText3.Completed = true;
   }
   
   myText3.CompletionDate = DateTime.Now;
*/