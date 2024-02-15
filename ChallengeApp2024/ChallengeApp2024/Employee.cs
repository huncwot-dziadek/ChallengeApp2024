namespace ChallengeApp2024
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();



        public Employee(string name, string surname, string sex, int age)
            : base(name, surname, sex, age)
        {
        }

        public void AddGrade(float grade)
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
        public void AddGrade(byte grade)
        {
            float floatFromByte = grade;
            if (floatFromByte <= 100)
            {
                AddGrade(floatFromByte);
            }
            else
            {
                throw new Exception("This grade is bigger 100");
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
                throw new Exception("This grade is not float");
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
