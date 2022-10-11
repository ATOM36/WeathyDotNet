using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;

using WeathyDotNet.Responses;
using System.Net.Http.Json;
using System.Net;

namespace WeathyDotNet.Requests
{
    public class OpenWeatherClient
    {
        private string units { get; set; }
        private string city { get; set; }
        private string appId { get; set; }

        //a77aa463da3599204abbaf825e980b26

        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://api.openweathermap.org/")
        };


        public OpenWeatherClient(string city, string appId, string units = "metrics")
        {
            this.units = units;
            this.city = city;
            this.appId = appId;
        }


        public async Task<OpenWeatherResponse> GetWeather()
        {
            try
            {
                _client.DefaultRequestHeaders.Accept.Clear();

                HttpResponseMessage requestResult = await _client.GetAsync($"data/2.5/weather?units={units}&q={city}&appId={appId}");

                if(requestResult.StatusCode == HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"There is no city of name {city}");
                    return OpenWeatherResponse.Empty();
                }
                else
                {
                    return await requestResult.Content.ReadFromJsonAsync<OpenWeatherResponse>(); ;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("An error occured");
                return OpenWeatherResponse.Empty();
            }
        }
    }
}
