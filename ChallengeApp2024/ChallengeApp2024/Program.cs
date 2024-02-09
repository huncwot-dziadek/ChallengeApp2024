using ChallengeApp2024;

User user1 = new User("Dupek");
User user2 = new User();
User user3 = new User("Debilka", "12345678");
User user4 = new User("Kretynka");


user1.AddScore(7);
user1.AddScore(17);

var result = user1.Result;

Console.WriteLine(result);
Console.WriteLine(User.GameName);

