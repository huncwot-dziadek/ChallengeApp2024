using ChallengeApp2024;
using static System.Net.Mime.MediaTypeNames;

Employee employee = new Employee("Euzebiusz", "Burek");

employee.AddGrade(99.2f);
employee.AddGrade(99.4D);
employee.AddGrade(99L);
employee.AddGrade("99");
employee.AddGrade('1');
employee.AddGrade('e');
employee.AddGrade("Adam");
employee.AddGrade("-1");

var statisticsForeach = employee.GetStatisticsWhenForeach();

Console.WriteLine();
Console.WriteLine("GetStatisticsWhenForeach");
Console.Write($"Max = {statisticsForeach.Max}   ");
Console.Write($"Min = {statisticsForeach.Min}   ");
Console.WriteLine($"Average = {statisticsForeach.Average:N2}");

var statisticsWhile = employee.GetStatisticsWhenWhile();

Console.WriteLine();
Console.WriteLine("GetStatisticsWhenWhile");
Console.Write($"Max = {statisticsWhile.Max}   ");
Console.Write($"Min = {statisticsWhile.Min}   ");
Console.WriteLine($"Average = {statisticsWhile.Average:N2}");

var statisticsDoWhile = employee.GetStatisticsWhenDoWhile();

Console.WriteLine();
Console.WriteLine("GetStatisticsWhenDoWhile");
Console.Write($"Max = {statisticsDoWhile.Max}   ");
Console.Write($"Min = {statisticsDoWhile.Min}   ");
Console.WriteLine($"Average = {statisticsDoWhile.Average:N2}");

var statisticsFor = employee.GetStatisticsWhenFor();

Console.WriteLine();
Console.WriteLine("GetStatisticsWhenFor");
Console.Write($"Max = {statisticsFor.Max}   ");
Console.Write($"Min = {statisticsFor.Min}   ");
Console.WriteLine($"Average = {statisticsFor.Average:N2}");
