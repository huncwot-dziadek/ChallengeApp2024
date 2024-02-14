using ChallengeApp2024;
using static System.Net.Mime.MediaTypeNames;

Employee employee = new Employee();

Console.WriteLine("Witaj w programie: PRACOWNIK MIESIĄCA");
Console.WriteLine("=====================================");
Console.WriteLine();

while(true)
{
    Console.Write("Podaj kolejną ocenę pracownika:  ");
    var input = Console.ReadLine();
    
    if(input == "Q" || input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine();
Console.Write($"Max = {statistics.Max}   ");
Console.Write($"Min = {statistics.Min}   ");
Console.Write($"Average = {statistics.Average:N2}   ");
Console.WriteLine($"AverageLetter = {statistics.AverageLetter}   ");

