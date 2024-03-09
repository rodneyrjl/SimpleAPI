using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }
    
    [Fact]
    public void GetForcast()
    {
        var returnValue = controller.Get();
        // Assert.Equal("Les Jackson", returnValue.ElementAt(0).Summary);
        Assert.Equal("Hot", returnValue.ElementAt(0).Summary);
    }

    WeatherForecastController controller = new WeatherForecastController();
}