namespace MotoApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var stackTest = new BasicStack<double>();
            stackTest.Push(item: 49.5);
            stackTest.Push(item: 113);
            stackTest.Push(item: 17.3);

            Assert.Pass();
        }
    }
}