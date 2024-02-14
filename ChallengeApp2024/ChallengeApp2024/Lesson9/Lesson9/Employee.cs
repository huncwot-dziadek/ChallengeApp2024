namespace Lesson9
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("This grade is out of range");
            }
        }
        public void AddGrade(byte grade)
        {
            float floatFromByte = (float)grade;
            if (floatFromByte <= 100)
            {
                this.grades.Add(floatFromByte);
            }
            else
            {
                Console.WriteLine("This grade is bigger 100");
            }
        }
        public void AddGrade(int grade)
        {
            float floatFromInt = (float)grade;
            AddGrade(floatFromInt);
        }
        public void AddGrade(long grade)
        {
            float floatFromLong = (float)grade;
            AddGrade(floatFromLong);
        }
        public void AddGrade(double grade)
        {
            float floatFromDouble = (float)grade;
            AddGrade(floatFromDouble);
        }
        public void AddGrade(char grade)
        {
            float floatFromChar = (float)grade;

            if (floatFromChar > 0 && floatFromChar < 58)
            {
                this.grades.Add(floatFromChar - 48);
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
                this.AddGrade(result);
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

            foreach (var grade in this.grades)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
