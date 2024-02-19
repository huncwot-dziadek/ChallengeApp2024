namespace ChallengeApp2024
{
    public interface ISupervisor
    {
        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        int Age { get; }

        string JobPosition { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
