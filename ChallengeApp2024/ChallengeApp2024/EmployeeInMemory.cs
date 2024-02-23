using System.Diagnostics;

namespace ChallengeApp2024
{
    public class EmployeeInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("This grade is out of range");
            }
        }

        public void EmployeeGradeAdded(object sender, EventArgs args)
        {
            base.EmployeeGradeAdded(sender, args);
        }

        public void AddGrade(int grade)
        {
            base.AddGrade(grade);
        }

        public void AddGrade(double grade)
        {
            base.AddGrade(grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("The letter is incorrect");
            }
        }
        public override void AddGrade(string grade)
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
                throw new Exception("This grade is not float");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
