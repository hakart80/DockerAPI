using DockerAPITest.Controllers;
using NUnit.Framework;
using System.Threading.Tasks;

[TestFixture]
public class ValueControllerTest
{
    ValuesController valuesController;

    [SetUp]
    public void Setup()
    {
        valuesController = new ValuesController();
    }

    [Test]
    public void ValuesGet_Success()
    {
        var values = valuesController.Get();

        Assert.IsNotNull(values);
        Assert.IsNotNull(values.Value);
        Assert.IsTrue((values.Value as string[]).Length > 1);
    }


    [Test]
    public void ValuesGetById_Success()
    {
        var values = valuesController.Get(1);

        Assert.IsNotNull(values);
        Assert.IsNotNull(values.Value);
        Assert.IsNotEmpty(values.Value);
    }

    //[Test]
    //public void ValuesGetById_Error()
    //{
    //    var values = valuesController.Get(1);

    //    Assert.IsNotNull(values);
    //    Assert.IsNotNull(values.Value);
    //    Assert.IsEmpty(values.Value);
    //}
}