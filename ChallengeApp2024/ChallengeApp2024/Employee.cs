﻿namespace ChallengeApp2024
{
    public class Employee
    {
        private List<float> allGradeList = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public float GradeSum
        {
            get
            {
                return this.allGradeList.Sum();
            }
        }
        public void AddGrade(float grade)
        {
            allGradeList.Add(grade);
        }
    }
}