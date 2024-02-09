using ChallengeApp2024;

List<int> sumsEmployeesList = new List<int>();

Employee empArnold = new Employee("Arnold", "Szwarc", 26);
Employee empMarianna = new Employee("Marianna", "Niepoprawna", 33);
Employee empZenobiusz = new Employee("Zenobiusz", "Spokrewniony", 42);

empArnold.AddGradeList(5);
empArnold.AddGradeList(7);
empArnold.AddGradeList(6);
empArnold.AddGradeList(3);
empArnold.AddGradeList(7);
sumsEmployeesList.Add(empArnold.gradeSum);


empMarianna.AddGradeList(7);
empMarianna.AddGradeList(8);
empMarianna.AddGradeList(8);
empMarianna.AddGradeList(6);
empMarianna.AddGradeList(9);
sumsEmployeesList.Add(empMarianna.gradeSum);


empZenobiusz.AddGradeList(2);
empZenobiusz.AddGradeList(3);
empZenobiusz.AddGradeList(1);
empZenobiusz.AddGradeList(7);
empZenobiusz.AddGradeList(5);
sumsEmployeesList.Add(empZenobiusz.gradeSum);

sumsEmployeesList.Sort();

foreach (int num in sumsEmployeesList)
{
    Console.WriteLine(num);
}


