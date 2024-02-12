namespace ChallengeApp2024.Tests
{
    public class Tests
    {

        [Test]
        public void WhetherTheSumOfTheFourRatingsIsCorrect()
        {
            //arrange
            Employee employee = new Employee("Zenon", "Bia³y", 44);
            employee.AddGrade(7);
            employee.AddGrade(3);
            employee.AddGrade(8);
            employee.AddGrade(-4);

            var sum = 7 + 3 + 8 + (-4);

            //act
            var gradesum = employee.GradeSum;

            //assert
            Assert.AreEqual(sum, gradesum);
        }
    }
}