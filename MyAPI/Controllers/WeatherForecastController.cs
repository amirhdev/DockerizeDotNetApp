using Microsoft.AspNetCore.Mvc;
using MyUtility;

namespace MyTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet("GetLength", Name = "GetLength")]
    public int GetLength()
    {
        var stringUtility = new StringUtility();
        return stringUtility.GetLength("amirhossein");
    }
}