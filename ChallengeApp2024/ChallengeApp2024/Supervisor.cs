using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp2024
{
    public class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();

        private bool oneOfTheConditionsIsMet = false;

        public Supervisor(string name, string surname) : base(name, surname)
        {
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("This grade is out of range");
            }
        }
        public void AddGrade(int grade)
        {
        }

        public void AddGrade(double grade)
        {
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100.0f);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80.0f);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60.0f);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40.0f);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20.0f);
                    break;
                default:
                    throw new Exception("The letter is incorrect");
            }
        }
        public override void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                if (grade[0] >= 49 && grade[0] <= 54)
                {
                    var rating = grade[0] - 48;
                    var valueRating = (rating - 1) * 20;
                    AddGrade(valueRating);
                }
                else
                {
                    throw new Exception("This grade is not float or is bigger 6");
                }
            }

            if (grade.Length == 2)
            {
                for (int i = 0; i < grade.Length; i++)
                {
                    for (int j = 1; j >= 0; j--)
                    {
                        if ((grade[i] >= 49 && grade[i] <= 54) && (grade[j] == 43))
                        {
                            var rating = grade[i] - 48;
                            var valueRating = ((rating - 1) * 20) + 5;
                            AddGrade(valueRating);
                            oneOfTheConditionsIsMet = true;
                        }
                        else if ((grade[i] >= 49 && grade[i] <= 54) && (grade[j] == 45))
                        {
                            var rating = grade[i] - 48;
                            var valueRating = ((rating - 1) * 20) - 5;
                            AddGrade(valueRating);
                            oneOfTheConditionsIsMet = true;
                        }
                        else
                        {
                            if (oneOfTheConditionsIsMet == false)
                            {
                                throw new Exception("Incorrectly entered rating");
                            }
                        }
                    }
                }
            }

            if (grade.Length > 2)
            {
                throw new Exception("This grade is not float or is bigger 6");
            }
        }
 
        public override Statistics GetStatistics()
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


