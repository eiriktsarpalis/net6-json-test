using System.Text.Json;
using System.Text.Json.Serialization;

namespace net6_json_test
{
#if NET6_0_OR_GREATER
    [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, 
        GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(Person))]
    internal partial class AppJsonContext : JsonSerializerContext
    {
    }
#endif
}