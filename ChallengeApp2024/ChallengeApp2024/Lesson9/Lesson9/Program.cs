using Lesson9;

Employee employee = new Employee("Euzebiusz", "Burek");
employee.AddGrade("109");
employee.AddGrade("Adam");
employee.AddGrade(5);
employee.AddGrade(106);
employee.AddGrade('1');
employee.AddGrade('e');
employee.AddGrade(7.0f);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Average = {statistics.Average:N2}");

