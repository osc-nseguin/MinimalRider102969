using Xunit;

namespace MinimalRider102969;

public class ExampleTestClass
{
    [Theory]
    [AutoFakeData]
    public void ExampleFailingTestWithNoOutput(IList<string> listMock, string message)
    {
        throw new Exception($"This will fail: {message}");
    }
    
    [Theory]
    [AutoFakeData]
    public void ExampleFailingTestWithOutput(string message)
    {
        throw new Exception($"This will fail: {message}");
    }
}