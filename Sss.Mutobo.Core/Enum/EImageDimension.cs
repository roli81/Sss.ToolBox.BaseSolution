﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sss.Mutobo.Core.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EImageDimension
    {
        
        Default,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "extra-large")]
        ExtraLarge
    }
}
