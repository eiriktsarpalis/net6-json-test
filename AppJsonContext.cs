using System.Text.Json;
using System.Text.Json.Serialization;

namespace net6_json_test
{
#if NET6_0_OR_GREATER
    [JsonSerializable(typeof(Person))]
    internal partial class AppJsonContext : JsonSerializerContext
    {
    }
#endif
}