using Task7;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMethod1()
        {
            Assert.IsTrue(Program.q(1, 2, 3, 4));
        }
        [Test]
        public void TestMethod2()
        {

            Assert.IsTrue(Program.q(1, 2, 3, 4));
        }
        [Test]
        public void TestMethod3()
        {
            Assert.IsTrue(Program.q(4, 2, 1, 5));
        }
    }
}