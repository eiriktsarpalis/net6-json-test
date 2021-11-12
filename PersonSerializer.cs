using BenchmarkDotNet.Attributes;
using System;
using System.Text.Json;

namespace net6_json_test
{
    public class PersonSerializer
    {
        private Person _person = new Person();
        private string _json = string.Empty;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Seed: 42);
            _person = new Person
            {
                FirstName = $"Joe-{random.Next(0, 3000)}",
                LastName = $"Soap-{random.Next(0, 3000)}",
                Age = random.Next(10, 90),
            };
            _json = JsonSerializer.Serialize(_person);
        }

        [Benchmark]
        public string Serialize_Reflection() => JsonSerializer.Serialize(_person);
        [Benchmark]
        public Person? Deserialize_Reflection() => JsonSerializer.Deserialize<Person>(_json);

#if NET6_0_OR_GREATER
        [Benchmark]
        public string Serialize_SourceGen() => JsonSerializer.Serialize(_person, AppJsonContext.Default.Person);
        [Benchmark]
        public Person? Deserialize_SourceGen() => JsonSerializer.Deserialize(_json, AppJsonContext.Default.Person);
#endif
    }
}