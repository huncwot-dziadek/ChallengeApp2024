using System.Diagnostics;

namespace ChallengeApp2024
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("This grade is out of range");
            }
        }
        public void AddGrade(byte grade)
        {
            float floatFromByte = grade;
            if (floatFromByte <= 100)
            {
                grades.Add(floatFromByte);
            }
            else
            {
                Console.WriteLine("This grade is bigger 100");
            }
        }
        public void AddGrade(int grade)
        {
            float floatFromInt = grade;
            AddGrade(floatFromInt);
        }
        public void AddGrade(long grade)
        {
            float floatFromLong = grade;
            AddGrade(floatFromLong);
        }
        public void AddGrade(double grade)
        {
            float floatFromDouble = (float)grade;
            AddGrade(floatFromDouble);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    break;
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                char charFromString = Convert.ToChar(grade[0]);
                AddGrade(charFromString);
            }
            else
            {
                Console.WriteLine("This grade is not float");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach (var grade in grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}

// MOJE CHAR POPRZEDNIE

//float floatFromChar = grade;

//if (floatFromChar > 0 && floatFromChar < 58)
//{
//    grades.Add(floatFromChar - 48);
//}
//else
//{
//    Console.WriteLine("This sign cannot be considered a number");
//}