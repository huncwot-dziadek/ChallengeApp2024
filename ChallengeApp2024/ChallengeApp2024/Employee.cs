namespace ChallengeApp2024
{
    public class Employee
    {
        private List<int> allGradeList = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int GradeSum
        {
            get
            {
                return allGradeList.Sum();
            }
        }
        public void AddGrade(int grade)
        {
            allGradeList.Add(grade);
        }
    }
}