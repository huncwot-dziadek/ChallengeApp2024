﻿namespace ChallengeApp2024
{
    public abstract class EmployeeBase : IEmployee
    {
        
        public delegate void GradeAddedDelegate(object sender, EventArgs args);


        public event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("New rating added");
        }


        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public void AddGrade(int grade)
        {
            float floatFromInt = grade;
            AddGrade(floatFromInt);
        }

        public void AddGrade(double grade)
        {
            float floatFromDouble = (float)grade;
            AddGrade(floatFromDouble);
        }

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();
    }
}
