namespace net6_json_test
{
    [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, 
        GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(Person))]
    internal partial class AppJsonContext : JsonSerializerContext
    {
    }
}