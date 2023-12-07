using Moq;
using Xunit;

namespace MinimalRider102969;

public class ExampleTestClass
{
    [Theory]
    [AutoMoqData]
    public void ExampleFailingTestWithNoOutput(Mock<IList<string>> listMock, string message)
    {
        throw new Exception($"This will fail: {message}");
    }
    
    [Theory]
    [AutoMoqData]
    public void ExampleFailingTestWithOutput(string message)
    {
        throw new Exception($"This will fail: {message}");
    }
}