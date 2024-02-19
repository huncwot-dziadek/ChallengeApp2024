﻿using ChallengeApp2024;

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
Console.WriteLine($"Average = {employeeInFile.GetStatistics().Average:N2}   ");
