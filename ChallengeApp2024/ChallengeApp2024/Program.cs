using ChallengeApp2024;
using static System.Runtime.InteropServices.JavaScript.JSType;

EmployeeInFile employeeInFile = new EmployeeInFile("Archibald", "Wykolejony");

Console.WriteLine($"Welcome to the program: OF THE MONTH");
Console.WriteLine("=============================================");
Console.WriteLine();

while (true)
{
    Console.Write("Provide another employee evaluation:  ");

    var input = Console.ReadLine();

    if (input == "Q" || input == "q")
    {
        break;
    }
    try
    {
        employeeInFile.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}






//employeeInFile.AddGrade(0.5f);
//employeeInFile.AddGrade($"{employeeInFile.Name} {employeeInFile.Surname}");

//try
//{
//    employeeInFile.GetStatistics();
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Exception catched: {ex.Message}");
//}

employeeInFile.ReadingFromFile();

Console.WriteLine();
Console.WriteLine("============================================");
Console.WriteLine($"{employeeInFile.Name} {employeeInFile.Surname} final results:");
Console.WriteLine($"Masimum rating = {employeeInFile.GetStatistics().Max}   ");
Console.WriteLine($"Mininum rating = {employeeInFile.GetStatistics().Min}   ");
Console.WriteLine($"Average rating = {employeeInFile.GetStatistics().Average:N2}   ");
Console.WriteLine("============================================");
Console.Write($"Max = {employeeInFile.GetStatistics().Max}   ");
Console.Write($"Min = {employeeInFile.GetStatistics().Min}   ");
Console.Write($"Average = {employeeInFile.GetStatistics().Average:N2}   ");
Console.WriteLine($"AverageLetter = {employeeInFile.GetStatistics().AverageLetter}   ");




/*
Supervisor supervisor = new Supervisor("Hieronim", "Niepodległy", "Male", 42, "MASTER");
Employee employee = new Employee("Antoni", "Wykop", "Male", 32, "WORKER");

var rated = supervisor;

EmployeeInMemory employeeIn = new EmployeeInMemory("Adam", "Marek");

Console.WriteLine();
employeeIn.SayHallo();




var statistics = rated.GetStatistics();

Console.WriteLine();
Console.WriteLine("============================================");
Console.WriteLine($"{rated.JobPosition} {rated.Name} {rated.Surname} final results:");
Console.WriteLine($"Masimum rating = {rated.GetStatistics().Max}   ");
Console.WriteLine($"Mininum rating = {rated.GetStatistics().Min}   ");
Console.WriteLine($"Average rating = {rated.GetStatistics().Average:N2}   ");
Console.WriteLine("============================================");
Console.Write($"Max = {statistics.Max}   ");
Console.Write($"Min = {statistics.Min}   ");
Console.Write($"Average = {statistics.Average:N2}   ");
Console.WriteLine($"AverageLetter = {statistics.AverageLetter}   ");

*/