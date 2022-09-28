using FilterDemoApp;
using FilterDemoApp.Controllers;

namespace FilterDemoTest
{
    public class FilterTest
    {
        [Fact]
        public void test_for_user_get()
        {
            UserController uc = new UserController();
            string result = uc.Get();
            Assert.Equal("Inside User Conteroller", result);
        }

        [Fact]
        public void test_for_weather_get()
        {
            WeatherForecastController wc = new WeatherForecastController();
            string result = wc.Get();
            Assert.Equal("Inside Weather Conteroller", result);
        }
    }
}