// WeatherService.cs
using System.Threading.Tasks;
using WeatherNow.Data;
using WeatherNow.Entities;

namespace WeatherNow.Business
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            return await _weatherRepository.GetWeatherAsync(city);
        }
    }
}
