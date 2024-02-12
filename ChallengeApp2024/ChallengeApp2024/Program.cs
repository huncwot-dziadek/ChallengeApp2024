using ChallengeApp2024;

List<Employee> employeesAll = new List<Employee>();

Employee empArnold = new Employee("Arnold", "Szwarc", 26);
Employee empMarianna = new Employee("Marianna", "Nieporadna", 33);
Employee empJerzy = new Employee("Jerzy", "Nieświeży", 42);
Employee empWitold = new Employee("Witold", "Przegraniec", 36);
Employee empJoanna = new Employee("Joanna", "Wyciszona", 34);
Employee empPatrycjusz = new Employee("Patrycjusz", "Wrzód", 40);

empArnold.AddGrade(5);
empArnold.AddGrade(7);
empArnold.AddGrade(6);
empArnold.AddGrade(3);
empArnold.AddGrade(7);
employeesAll.Add(empArnold);

empJoanna.AddGrade(7);
empJoanna.AddGrade(8);
empJoanna.AddGrade(2);
empJoanna.AddGrade(6);
empJoanna.AddGrade(2);
employeesAll.Add(empJoanna);

empPatrycjusz.AddGrade(7);
empPatrycjusz.AddGrade(9);
empPatrycjusz.AddGrade(7);
empPatrycjusz.AddGrade(6);
empPatrycjusz.AddGrade(9);
employeesAll.Add(empPatrycjusz);

empWitold.AddGrade(2);
empWitold.AddGrade(1);
empWitold.AddGrade(1);
empWitold.AddGrade(9);
empWitold.AddGrade(9);
employeesAll.Add(empWitold);

empJerzy.AddGrade(7);
empJerzy.AddGrade(5);
empJerzy.AddGrade(5);
empJerzy.AddGrade(6);
empJerzy.AddGrade(7);
employeesAll.Add(empJerzy);

empMarianna.AddGrade(2);
empMarianna.AddGrade(3);
empMarianna.AddGrade(1);
empMarianna.AddGrade(7);
empMarianna.AddGrade(5);
employeesAll.Add(empMarianna);

employeesAll.Sort((x, y) => x.GradeSum.CompareTo(y.GradeSum));

Console.WriteLine("Najwyższą ocenę uzyskał(a): ");
Console.Write(employeesAll[employeesAll.Count - 1].Name + " ");
Console.Write(employeesAll[employeesAll.Count - 1].Surname + " ");
Console.WriteLine("Lat " + employeesAll[employeesAll.Count - 1].Age);
Console.WriteLine("i uzyskał(a) " + employeesAll[employeesAll.Count - 1].GradeSum + " pkt");
