using System.Runtime.Serialization;

namespace AppResponse.Enums;

public enum ResponseStatus
{
    /// <summary>
    /// Успшно
    /// </summary>
    [EnumMember(Value = "SUCCESS")]
    Success,
    
    /// <summary>
    /// Ошибка
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error,
    
    /// <summary>
    /// Частично доступно
    /// </summary>
    [EnumMember(Value = "PART_UNAVAILABLE")]
    PartUnavailable
}