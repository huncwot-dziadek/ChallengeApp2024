using Lesson9;

Employee employee = new Employee("Euzebiusz", "Burek");
employee.AdGrade("3");
employee.AdGrade("Adam");
employee.AdGrade(5);
employee.AdGrade(106);
employee.AdGrade('8');
employee.AdGrade('e');
employee.AdGrade(7.0f);

var statistics = employee.GetStatistics();

Console.WriteLine($"Max = {statistics.Max}");
Console.WriteLine($"Min = {statistics.Min}");
Console.WriteLine($"Average = {statistics.Average:N2}");

