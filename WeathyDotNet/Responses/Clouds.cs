using Newtonsoft.Json;

namespace WeathyDotNet.Responses;

public class Clouds
{
    [JsonProperty("all")]
    public int All { get; set; }
}
