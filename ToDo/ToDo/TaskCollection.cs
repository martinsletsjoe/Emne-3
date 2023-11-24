namespace ToDo;

public class TaskCollection
{
    private List<Task> _tasks = CreateTasks();


    public void Show()
    {
        Console.WriteLine("To Do List ");
        Console.WriteLine(" Dagens dato: " + DateTime.Now + "\n");

        foreach (var task in _tasks)
        {
            if (task.IsDone)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                //Console.WriteLine();
                Console.WriteLine("Fullførte oppgaver:");
                Console.WriteLine(task.Name);
                Console.WriteLine(task.CompletionDate);
                Console.ResetColor();
            }
            else
            {
                CreateTasksText(task);
            }

            Console.WriteLine();
            //Console.WriteLine(task.Name);
            //var timeOfDay = task.DueDate.TimeOfDay;

            //var taskDue = task.DueDate.ToString();


            //if (timeOfDay == TimeSpan.Zero)
            //{
            //    taskDue = task.DueDate.ToString("dd MM yyyy");
            //}
            //Console.Write(" - " + task.Name);
            //Console.WriteLine(" Frist: " + taskDue);
            //Console.WriteLine(task.IsDone ? $"   Oppgaven ble fullført {task.CompletionDate}" : "   Oppgaven er uferdig");
            ////Console.WriteLine("Er oppgaven fullført? "+ myTasks.Completed ? "ja": "nei");
            //Console.WriteLine();
        }
    }

    private static void CreateTasksText(ToDo.Task task)
    {
        Console.WriteLine(task.Name);
        Console.WriteLine("Frist: "+task.DueDate.ToString("dd/MM/yy"));
        //Console.WriteLine(task.IsDone ? "ja" : "nei");
    }


    private static List<Task> CreateTasks()
    {
        return new List<Task>
        {
            new Task()
            {
                Name = "Vask bil",
                DueDate = new DateTime(2023, 11, 22),
                IsDone = false,
                CompletionDate = new DateTime(2023, 11, 15, 14, 30, 0).ToString(),
            },
            new Task()
            {
                Name = "Gå tur med hund",
                DueDate = new DateTime(2023, 12, 22),
                IsDone = false,
                CompletionDate = new DateTime(2023, 11, 14, 15, 23, 00).ToString(),
            },
            new Task()
            {
                Name = "Støvsuge",
                DueDate = new DateTime(2023, 11, 22),
                IsDone = true,
                CompletionDate = new DateTime(2023, 11, 14, 02, 03, 40).ToString(),
            },
        };
    }

    public int GetCount()
    {
        return _tasks.Count;
    }

    public void MarkComplete(int taskNo)
    {
        _tasks[taskNo - 1].IsDone = true;
        _tasks[taskNo - 1].CompletionDate = DateTime.Now.ToString();
    }

    public void AddTask(string name, DateTime dueDate)
    {
        var task = new Task();
        task.Name = name;
        task.DueDate = dueDate;
        task.IsDone = false;
        task.CompletionDate = "";
        _tasks.Add(task);
    }

}

//kl.13.15 sletting av oppgaver

//lagring av oppgaver