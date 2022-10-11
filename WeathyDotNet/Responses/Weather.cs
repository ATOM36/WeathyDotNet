using Newtonsoft.Json;

namespace WeathyDotNet.Responses;

public class Weather
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("main")]
    public string? Main { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("icon")]
    [JsonIgnore]
    public string? Icon { get; set; }
}
