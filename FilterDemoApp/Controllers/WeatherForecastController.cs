using Microsoft.AspNetCore.Mvc;

namespace FilterDemoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]

    // This is at the controller level filter which gives us the name of the
    // controller classes which class is being executed in order with there name.
    [MyActionFilter("User")]
    public class UserController : ControllerBase
    {
        public string Get()
        {
            return "Inside User Conteroller";
        }
    }


    [ApiController]
    [Route("[controller]")]

    // This is at the controller level filter which gives us the name of the
    // controller classes which class is being executed in order with there name.
   
    [MyActionFilter("controller")]

    public class WeatherForecastController : ControllerBase
    {
        public string Get()
        {
            return "Inside Weather Conteroller";
        }

    }
}