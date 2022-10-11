using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WeathyDotNet.Responses;

public class OpenWeatherResponse
{
    [JsonPropertyName("coord")]
    public Coordinates? Coord { get; set; }


    [JsonPropertyName("weather")]
    public List<Weather>? Weather{ get; set; }  


    [JsonPropertyName("main")]
    public Main? MainData{ get; set; }


    [JsonPropertyName("visibility")]
    public int Visibility{ get; set; }


    [JsonPropertyName("wind")]
    public Wind? Wind{ get; set; }


    [JsonPropertyName("clouds")]
    public Clouds? Clouds{ get; set; }

    public static OpenWeatherResponse Empty() => new OpenWeatherResponse();
}
