using System.Text.Json.Serialization;
using AppResponse.Enums;

namespace AppResponse.Response;

public class ExceptionResponse : Exception
{
    [JsonPropertyName("status")]
    public ResponseStatus Status { get; set; }
    
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; set; }
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public System.Net.HttpStatusCode? HttpStatusCode { get; set; }
}