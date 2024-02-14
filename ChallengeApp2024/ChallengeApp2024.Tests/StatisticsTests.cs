using ChallengeApp2024;

namespace Lesson9.Tests
{
    public class Tests
    {

        [Test]
        public void WhetherTheSatisticsFindTheRangeOfMaxCorrectly()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);
        }

        [Test]
        public void WhetherTheSatisticsFindTheRangeOfMinCorrectly()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, statistics.Min);
        }

        [Test]
        public void WetherTheSatisticsCalculateTheAverageCorrectly()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AddGrade(3);
            employee.AddGrade(5);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            float average = (float)(3 + 5 + 6) / 3;

            Assert.AreEqual(average, statistics.Average);
        }
    }
}