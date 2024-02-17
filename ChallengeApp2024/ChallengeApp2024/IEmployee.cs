namespace ChallengeApp2024
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        int Age { get; }

        string JobPosition { get; }

        void AddGrade(float grade);

        void AddGrade(int grade);

        void AddGrade(double grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}

