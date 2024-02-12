namespace Lesson9.Tests
{
    public class Tests
    {

        [Test]
        public void DoSatisticsFindTheNumberOfMax()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AdGrade(3);
            employee.AdGrade(5);
            employee.AdGrade(-6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(5, statistics.Max);
        }

        [Test]
        public void DoSatisticsFindTheNumberOfMin()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AdGrade(3);
            employee.AdGrade(5);
            employee.AdGrade(-6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(-6, statistics.Min);
        }

        [Test]
        public void WetherSatisticsCalculateTheAverageCorrectly()
        {
            Employee employee = new Employee("Konrad", "Wagabunda");
            employee.AdGrade(3);
            employee.AdGrade(5);
            employee.AdGrade(6);
            var statistics = employee.GetStatistics();

            float average = (float)(3 + 5 + 6) / 3;

            Assert.AreEqual(average, statistics.Average);
        }
    }
}