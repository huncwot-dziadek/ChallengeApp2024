using Lesson9;

Employee employee = new Employee("Euzebiusz", "Burek");
employee.AdGrade(3);
employee.AdGrade(5);
employee.AdGrade(6);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Average = {statistics.Average:N2}");

