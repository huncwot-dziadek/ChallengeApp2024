namespace ChallengeApp2024
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        void EmployeeGradeAdded(object sender, EventArgs args);

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}

