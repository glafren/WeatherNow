using Microsoft.AspNetCore.Mvc;
using WeatherNow.Business;

namespace WeatherNow.Web.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return View();
            }

            var weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }
    }
}
