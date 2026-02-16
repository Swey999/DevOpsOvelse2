using ConsoleDevOps;

namespace AutoTests;

public class Tests
{
    [SetUp]
    public void Setup() { }
    [Test]
    public void KoererDockerVirkeligVoresTests()
    {
        //dog
        //dog2
        //dog3
        int i = 1 + 1;
        Assert.That(i, Is.EqualTo(2));
    }
    [Test]
    public void IntegrationstestForNumbersOgPlusNumbers()
    {
        Assert.That(Program.PlusNumbers(), Is.EqualTo(19));
    }
}
