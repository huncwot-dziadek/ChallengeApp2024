namespace ChallengeApp2024
{
    public class User
    {
        public static string GameName = "Wiedżmin";

        private List<int> scores = new List<int>();

        public User()
        {
            this.Login = "-";
            this.Password = "-";
        }
        public User(string login)
        {
            this.Login = login;
            this.Password = "-";
        }
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.scores.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.scores.Add(number);
        }

    }
}
