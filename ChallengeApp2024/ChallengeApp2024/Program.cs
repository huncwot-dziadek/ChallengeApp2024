using ChallengeApp2024;

Employee employee = new Employee("Hieronim", "Niepodległy", "Male", 22);

Console.WriteLine("Welcome to the program: EMPLOYEE OF THE MONTH");
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
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine();
<<<<<<< HEAD
Console.Write($"Max = {statistics.Max}   ");
Console.Write($"Min = {statistics.Min}   ");
Console.Write($"Average = {statistics.Average:N2}   ");
Console.WriteLine($"AverageLetter = {statistics.AverageLetter}   ");
=======
Console.WriteLine("============================================");
Console.WriteLine($"{employee.Name} {employee.Surname} final results:");
Console.WriteLine($"Masimum rating = {statistics.Max}   ");
Console.WriteLine($"Mininum rating = {statistics.Min}   ");
Console.WriteLine($"Average rating = {statistics.Average:N2}   ");
Console.WriteLine("============================================");
>>>>>>> 44a4ec67e3e10e91349ed57c5b6283260163bb12

