namespace ChallengeApp2024
{
    public class Employee
    {
        private List<float> grades = new List<float>();

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
            float floatFromChar = grade;

            if (floatFromChar > 0 && floatFromChar < 58)
            {
                grades.Add(floatFromChar - 48);
            }
            else
            {
                Console.WriteLine("This sign cannot be considered a number");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
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
            return statistics;
        }
    }
}
