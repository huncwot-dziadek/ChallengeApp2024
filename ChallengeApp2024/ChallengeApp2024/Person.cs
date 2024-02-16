namespace ChallengeApp2024
{
    public abstract class Person
    {
        public Person(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
<<<<<<< HEAD
        public int Age { get; private set; }

        int zmienna;

=======
>>>>>>> 44a4ec67e3e10e91349ed57c5b6283260163bb12
    }
}
