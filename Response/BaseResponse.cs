using System.Text.Json.Serialization;
using AppResponseExtension.Converter;
using AppResponseExtension.Enums;

namespace AppResponseExtension.Response;

public class BaseResponse<T> : BaseResponse
{
    public T? Data { get; set; }
}

public class BaseResponse
{
    [JsonConverter(typeof(JsonEnumToUppercaseStringConverter<ResponseStatus>))]
    public ResponseStatus Status { get; set; } = ResponseStatus.Success;
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string StatusMessage {  get; set; } = null!;
}
