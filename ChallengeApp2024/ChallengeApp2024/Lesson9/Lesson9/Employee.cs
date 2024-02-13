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

        public void AdGrade(float grade)
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

        public void AdGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AdGrade(result);
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
