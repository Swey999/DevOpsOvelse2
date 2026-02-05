namespace AutoTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KoererDockerVirkeligVoresTests()
        {
            //dog
            int i = 1 + 1;
            Assert.That(i, Is.EqualTo(3));
        }
    }
}