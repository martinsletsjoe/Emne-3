Console.Write("Hva heter du? ");
var name = Console.ReadLine();
Console.WriteLine($"Hei, {name}!");
Console.Write("Når ble du født? ");

var birthYearStr = Console.ReadLine();
var birthYear = Convert.ToInt32(birthYearStr);
var age = 2023 - birthYear;
Console.WriteLine($"Da er du {age}år gammel");


//var issuccess = true;
//var n = 0;
//var c = 'c';
//var s = "martin";

//bool issuccess = true;
//int n = 0;
//char c = 'c';
//string s = "martin";