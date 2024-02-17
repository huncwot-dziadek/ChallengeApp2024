using ChallengeApp2024;

Supervisor supervisor = new Supervisor("Hieronim", "Niepodległy", "Male", 42, "MASTER");
Employee employee = new Employee("Antoni", "Wykop", "Male", 32, "WORKER");

var rated = supervisor;

Console.WriteLine($"Welcome to the program: {rated.JobPosition} OF THE MONTH");
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
        rated.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

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

