using ChallengeApp2024;

public class LetterGradeTests
{
    [Test]
    public void WhetherLetterACountedCorrectly()
    {
        Employee employee = new Employee("Hieronim", "Podległy","K", 14);
        employee.AddGrade("A");
        employee.AddGrade("a");
        var statistics = employee.GetStatistics();

        Assert.AreEqual(100, statistics.Average);
        Assert.AreEqual(100, statistics.Max);
        Assert.AreEqual(100, statistics.Min);

    }
    [Test]
    public void WhetherLetterBCountedCorrectly()
    {
        Employee employee = new Employee("Hieronim", "Podległy", "K", 14);
        employee.AddGrade("B");
        employee.AddGrade("b");
        var statistics = employee.GetStatistics();

        Assert.AreEqual(80, statistics.Average);
        Assert.AreEqual(80, statistics.Max);
        Assert.AreEqual(80, statistics.Min);

    }
    [Test]
    public void WhetherLetterCCountedCorrectly()
    {
        Employee employee = new Employee("Hieronim", "Podległy", "K", 14);
        employee.AddGrade("C");
        employee.AddGrade("c");
        var statistics = employee.GetStatistics();

        Assert.AreEqual(60, statistics.Average);
        Assert.AreEqual(60, statistics.Max);
        Assert.AreEqual(60, statistics.Min);

    }
    [Test]
    public void WhetherLetterDCountedCorrectly()
    {
        Employee employee = new Employee("Hieronim", "Podległy", "K", 14);
        employee.AddGrade("D");
        employee.AddGrade("d");
        var statistics = employee.GetStatistics();

        Assert.AreEqual(40, statistics.Average);
        Assert.AreEqual(40, statistics.Max);
        Assert.AreEqual(40, statistics.Min);

    }
    [Test]
    public void WhetherLetterECountedCorrectly()
    {
        Employee employee = new Employee("Hieronim", "Podległy", "K", 14);
        employee.AddGrade("E");
        employee.AddGrade("e");
        var statistics = employee.GetStatistics();

        Assert.AreEqual(20, statistics.Average);
        Assert.AreEqual(20, statistics.Max);
        Assert.AreEqual(20, statistics.Min);

    }

}
