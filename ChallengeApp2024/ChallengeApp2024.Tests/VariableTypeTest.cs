namespace ChallengeApp2024.Tests
{
    public class TypeTest
    {

        [Test]
        public void ValueTypeTest_Float()
        {
            var variable1 = 7.25;
            var variable2 = 14.5;
            var variable3 = 2 * variable1;

            Assert.AreEqual(variable3, variable2);
        }
        [Test]
        public void ValueTypeTest_Int()
        {
            Employee employee1 = new Employee("Zenon", "Biały", 44);
            Employee employee2 = new Employee("Zenon", "Czarny", 44);

            Assert.AreEqual(employee1.Age, employee2.Age);
        }
        [Test]
        public void ValueTypeTest_String()
        {
            Employee employee1 = new Employee("Zenon", "Biały", 44);
            Employee employee2 = new Employee("Zenon", "Czarny", 44);

            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void ReferenceTypeTest()
        {
            Employee employee1 = new Employee("Zenon", "Czarny", 44);
            Employee employee2 = new Employee("Zenon", "Czarny", 44);

            Assert.AreNotEqual(employee1, employee2);
        }
    }
}