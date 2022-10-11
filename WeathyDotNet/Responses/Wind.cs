using Newtonsoft.Json;

namespace WeathyDotNet.Responses;

public class Wind
{
    [JsonProperty("speed")]
    public double Speed { get; set; }

    [JsonProperty("deg")]
    [JsonIgnore]
    public int Deg { get; set; }

    [JsonProperty("gust")]
    [JsonIgnore]
    public double Gust { get; set; }
}