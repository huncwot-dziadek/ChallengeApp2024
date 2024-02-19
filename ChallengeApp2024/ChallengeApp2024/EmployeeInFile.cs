namespace ChallengeApp2024
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> gradesInMemory = new List<float>();

        private const string fileName = "grades2.txt";

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public void AddGradesToFile(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                foreach(var gradeToFile in gradesInMemory)
                {
                    writer.WriteLine(grade);
                }        
            }
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                //this.gradesInMemory.Add(grade);
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("This grade is out of range");
            }
        }

        public override void AddGrade(int grade)
        {
        }

        public override void AddGrade(double grade)
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

        public void ReadingFromFile()
        {
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        if (float.TryParse(line, out float number))
                        {
                            this.gradesInMemory.Add(number);

                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach (var grade in gradesInMemory)
            {
                statistics.Average += grade;
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
            }

            statistics.Average /= gradesInMemory.Count;

            return statistics;
        }    
    }
}
