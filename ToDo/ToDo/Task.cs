namespace ToDo;

public class Task
{
    public string Name;
    public DateTime DueDate;
    public bool IsDone = false;
    public string CompletionDate;

}



/*
 Lag en enkel todo-app med objekter. Hver oppgave har en tekst, en DueDate (dato, les dere opp på DateTime),
og om den er gjort eller ikke  + dato når den ble gjort. 
Lag en liste av oppgaver og kode som viser dem på en pen måte.
La brukeren velge fra en meny: legg til ny eller marker som gjort.
*/