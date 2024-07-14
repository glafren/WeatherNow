using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherNow.Entities;

namespace WeatherNow.Data
{
    public interface IWeatherRepository
    {
        Task<WeatherResponse> GetWeatherAsync(string city);
    }
}
