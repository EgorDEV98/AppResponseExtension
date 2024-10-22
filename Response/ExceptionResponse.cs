using System.Text.Json.Serialization;
using AppResponseExtension.Enums;

namespace AppResponseExtension.Response;

public class ExceptionResponse : Exception
{
    public ResponseStatus Status { get; set; } = ResponseStatus.Error;
    
    public string StatusMessage { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public System.Net.HttpStatusCode? HttpStatusCode { get; set; }

}