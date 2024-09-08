using System.Text.Json.Serialization;
using AppResponse.Converter;
using AppResponse.Enums;

namespace AppResponse.Response;

public class BaseResponse<T> : BaseResponse
{
    /// <summary>
    /// Данные ответа
    /// </summary>
    [JsonPropertyName("data")]
    public T? Data { get; set; }
}

public class BaseResponse
{
    /// <summary>
    /// Статус ответа
    /// </summary>
    [JsonPropertyName("status")]
    [JsonConverter(typeof(JsonEnumToUppercaseStringConverter<ResponseStatus>))]
    public ResponseStatus Status { get; set; } 
    
    /// <summary>
    /// Сообщение
    /// </summary>
    [JsonPropertyName("statusMessage")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? StatusMessage {  get; set; } = null!;
}