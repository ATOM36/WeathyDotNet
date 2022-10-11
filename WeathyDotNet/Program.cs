using WeathyDotNet.Requests;
using WeathyDotNet.Responses;

using static System.Console;

public class Program
{
    private static async Task Main(string[] args)
    {
        string? cityName = args.AsQueryable().FirstOrDefault();

        if (cityName == null)
        {
            WriteLine("Please give a city name:");
            cityName = ReadLine()!.Trim();
        }

        var client = new OpenWeatherClient(cityName, "YOUR_API_KEY");
        OpenWeatherResponse response = await client.GetWeather();

        WriteLine($"Current weather in {cityName.ToUpper()}");
        WriteLine($"Weather: {response?.Weather![0].Description}");
        WriteLine($"Temperature {response?.MainData!.Temp} °C");
        WriteLine($"Humidity {response?.MainData!.Humidity} %");
        WriteLine($"Wind: {response?.Wind?.Speed}m/s, {response?.Wind?.Deg}°");
        WriteLine($"Clouds: {response?.Clouds?.All}%");
        WriteLine($"Visibility: {response?.Visibility} on 10KM");
    }
}