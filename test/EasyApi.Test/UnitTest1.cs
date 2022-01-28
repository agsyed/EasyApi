using Xunit;
using EasyApi.Controllers;

namespace EasyApi.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void returnsWeatherForecast() 
    {
        var returnValue = controller.GetMockWeather();
        Assert.True("Good1".Equals(returnValue.Value));
    }

    [Fact]
    public void Test1()
    {

    }
}