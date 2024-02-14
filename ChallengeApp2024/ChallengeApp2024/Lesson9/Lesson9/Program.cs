using Lesson9;

Employee employee = new Employee("Euzebiusz", "Burek");
employee.AddGrade(99.2f);
employee.AddGrade(99.4D);
employee.AddGrade(99L);
employee.AddGrade("99");
employee.AddGrade('1');
employee.AddGrade('e');
employee.AddGrade("Adam");
employee.AddGrade("-1");

var statistics = employee.GetStatistics();

Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Average = {statistics.Average:N2}");

