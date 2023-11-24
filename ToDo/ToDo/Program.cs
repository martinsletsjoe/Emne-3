using System.ComponentModel;

namespace ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myTasks = new TaskCollection();

            while (true)
            {
                Console.Clear();
                myTasks.Show();
                var cmd = GetUserCmd();
                if (cmd == "1")
                {
                    AddTask(myTasks);
                }
                else if (cmd == "2")
                {
                    MarkComplete(myTasks);
                }


            }
        }

        private static void AskUserForTask(List<Task> myTasks)
        {
            //if (userInput == "1")
            //{
            //    var newTask = new Task();
            //    Console.WriteLine("Beskriv oppgaven");
            //    newTask.Name = Console.ReadLine();
            //    Console.WriteLine("Når skal den være ferdig? (dd/mm/yyyy");
            //    newTask.DueDate = Convert.ToDateTime(Console.ReadLine());
            //    myTasks.Add(newTask);
            //}
            //else if (userInput == "2")
            //{
            //    Console.WriteLine("Skriv nr til oppgaven du ønsker å markere som ferdig");
            //    var markedTask = Console.ReadLine();
            //    myTasks[int.Parse(markedTask) - 1].IsDone = true;
            //}
        }

        private static string GetUserCmd()
        {
            Console.WriteLine("Vil du legge til fler?");
            Console.WriteLine("1 = Legg til ny");
            Console.WriteLine("2 = Marker fullført");

            var userInput = Console.ReadLine();
            return userInput;
        }

        // single resonsibility principle

        private static void AddTask(TaskCollection myTasks)
        {
            Console.WriteLine("Beskrivelse: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hvilken frist skal den ha? (dd/MM/yy");
            var taskDue = Console.ReadLine();

            myTasks.AddTask(name, Convert.ToDateTime(taskDue));
        }

        private static void MarkComplete(TaskCollection myTasks)
        {
            Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
            var taskNoStr = Console.ReadLine();
            var taskNo = Convert.ToInt32(taskNoStr);
            if (taskNo < 0 || taskNo > myTasks.GetCount())
            {
                Console.WriteLine("Listen starter fra 1, prøv igjen");
            }
            else
            {
                myTasks.MarkComplete(taskNo);
            }
        }
    }
}


/*
 Lag en enkel todo-app med objekter. Hver oppgave har en tekst, en DueDate (dato, les dere opp på DateTime),
og om den er gjort eller ikke  + dato når den ble gjort. Lag en liste av oppgaver og kode som viser dem på en pen måte. 
La brukeren velge fra en meny: legg til ny eller marker som gjort.
*/

