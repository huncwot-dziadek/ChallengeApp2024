using ChallengeApp2024;

List<int> sumsEmployeesList = new List<int>();

List<Employee> employees = new List<Employee>();

Employee empArnold = new Employee("Arnold", "Szwarc", 26);
Employee empMarianna = new Employee("Marianna", "Niepoprawna", 33);
Employee empZenobiusz = new Employee("Zenobiusz", "Spokrewniony", 42);

empArnold.AddGradeList(5);
empArnold.AddGradeList(7);
empArnold.AddGradeList(6);
empArnold.AddGradeList(3);
empArnold.AddGradeList(7);
sumsEmployeesList.Add(empArnold.gradeSum);
employees.Add(empArnold);



empMarianna.AddGradeList(7);
empMarianna.AddGradeList(8);
empMarianna.AddGradeList(8);
empMarianna.AddGradeList(6);
empMarianna.AddGradeList(9);
sumsEmployeesList.Add(empMarianna.gradeSum);
employees.Add(empMarianna);



empZenobiusz.AddGradeList(2);
empZenobiusz.AddGradeList(3);
empZenobiusz.AddGradeList(1);
empZenobiusz.AddGradeList(7);
empZenobiusz.AddGradeList(5);
sumsEmployeesList.Add(empZenobiusz.gradeSum);
employees.Add(empZenobiusz);


sumsEmployeesList.Sort();
employees.Sort((x, y) => x.gradeSum.CompareTo(y.gradeSum));

foreach (int num in sumsEmployeesList)
{
    Console.WriteLine(num);
}



foreach (Employee num in employees)
{
    Console.WriteLine(employees[employees.Count-1].Name);
}


//people.Sort((x, y) => x.Age.CompareTo(y.Age));