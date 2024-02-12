using ChallengeApp2024;

List<Employee> employeesAll = new List<Employee>();

Employee empArnold = new Employee("Arnold", "Szwarc", 26);
Employee empMarianna = new Employee("Marianna", "Nieporadna", 33);
Employee empJerzy = new Employee("Jerzy", "Nieświeży", 42);
Employee empWitold = new Employee("Witold", "Przegraniec", 36);
Employee empJoanna = new Employee("Joanna", "Wyciszona", 34);
Employee empPatrycjusz = new Employee("Patrycjusz", "Wrzód", 40);

empArnold.AddGradeList(5);
empArnold.AddGradeList(7);
empArnold.AddGradeList(6);
empArnold.AddGradeList(3);
empArnold.AddGradeList(7);
employeesAll.Add(empArnold);

empJoanna.AddGradeList(7);
empJoanna.AddGradeList(8);
empJoanna.AddGradeList(2);
empJoanna.AddGradeList(6);
empJoanna.AddGradeList(2);
employeesAll.Add(empJoanna);

empPatrycjusz.AddGradeList(7);
empPatrycjusz.AddGradeList(9);
empPatrycjusz.AddGradeList(7);
empPatrycjusz.AddGradeList(6);
empPatrycjusz.AddGradeList(9);
employeesAll.Add(empPatrycjusz);

empWitold.AddGradeList(2);
empWitold.AddGradeList(1);
empWitold.AddGradeList(1);
empWitold.AddGradeList(9);
empWitold.AddGradeList(9);
employeesAll.Add(empWitold);

empJerzy.AddGradeList(7);
empJerzy.AddGradeList(5);
empJerzy.AddGradeList(5);
empJerzy.AddGradeList(6);
empJerzy.AddGradeList(7);
employeesAll.Add(empJerzy);

empMarianna.AddGradeList(2);
empMarianna.AddGradeList(3);
empMarianna.AddGradeList(1);
empMarianna.AddGradeList(7);
empMarianna.AddGradeList(5);
employeesAll.Add(empMarianna);

employeesAll.Sort((x, y) => x.gradeSum.CompareTo(y.gradeSum));

Console.WriteLine("Najwyższą ocenę uzyskał(a): ");
Console.Write(employeesAll[employeesAll.Count - 1].Name + " ");
Console.Write(employeesAll[employeesAll.Count - 1].Surname + " ");
Console.WriteLine("Lat " + employeesAll[employeesAll.Count - 1].Age);
Console.WriteLine("i uzyskał(a) " + employeesAll[employeesAll.Count - 1].gradeSum + " pkt");
