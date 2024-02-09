﻿namespace ChallengeApp2024
{
    public class Employee
    {
        private List<int> gradeList = new List<int>();

        

        public Employee(string name, string surname, int age) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set;}

        public int gradeSum
        {
            get
            {
                return gradeList.Sum();
            }
        }


        public void AddGradeList(int grade) 
        {
            gradeList.Add(grade);
        }




    }
}
