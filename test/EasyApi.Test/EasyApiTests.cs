using Xunit;
using EasyApi.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace EasyApi.Test;

public class EasyApiTests
{

    [Fact]
    public void returnsWeatherForecast() 
    {
        var loggerStub = new Mock<ILogger<WeatherForecastController>>();

        WeatherForecastController controller = new WeatherForecastController(loggerStub.Object);
        var returnValue = controller.GetMockWeather();
        Assert.True("Good".Equals(returnValue.Value));
    }

    [Fact]
    public void Test1()
    {

    }
}