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

        public Statistics GetStatisticsWhenForeach()
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

        public Statistics GetStatisticsWhenFor()
        {
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            for (int index = 0; index < grades.Count; index++)
            {
                statistics.Average += grades[index];
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
            }

            statistics.Average /= grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWhenDoWhile()
        {
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;
            int index = 0;

            do
            {
                statistics.Average += grades[index];
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                index++;
            } while (index < grades.Count);

            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhenWhile()
        {
            var statisticsWhile = new Statistics();

            statisticsWhile.Min = float.MaxValue;
            statisticsWhile.Max = float.MinValue;
            statisticsWhile.Average = 0;
            int index = 0;

            while (index < grades.Count)
            {
                statisticsWhile.Average += grades[index];
                statisticsWhile.Max = Math.Max(statisticsWhile.Max, grades[index]);
                statisticsWhile.Min = Math.Min(statisticsWhile.Min, grades[index]);
                index++;
            }

            statisticsWhile.Average /= grades.Count;
            return statisticsWhile;
        }

    }

}
