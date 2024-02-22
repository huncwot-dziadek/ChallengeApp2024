namespace ChallengeApp2024
{
    public class EmployeeInFile : EmployeeBase
    {

        public event GradeAddedDelegate GradeAdded;


        private List<float> gradesInMemory = new List<float>();


        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

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
            Console.Write($"{this.Name} {this.Surname}: ");
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
            if ((grade >= 65 && grade <= 69) || (grade >= 97 && grade <= 101))
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
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        AddGrade(100.0f);
                        break;
                    case "B":
                    case "b":
                        AddGrade(80.0f);
                        break;
                    case "C":
                    case "c":
                        AddGrade(60.0f);
                        break;
                    case "D":
                    case "d":
                        AddGrade(40.0f);
                        break;
                    case "E":
                    case "e":
                        AddGrade(20.0f);
                        break;
                    default:
                        throw new Exception("The letter is incorrect");
                }
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

        //public override void WywolajDelegata()
        //{
        //    base.GradeAdded += EmployeeInFileGradeAdded;
        //}

        //private void EmployeeInFileGradeAdded(object sender, EventArgs args)
        //{
        //    Console.WriteLine("Dopisano ocenę do pliku");
        //}
    }
}
