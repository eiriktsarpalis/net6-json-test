using net6_json_test;
using BenchmarkDotNet.Running;

Console.WriteLine(BenchmarkRunner.Run<PersonSerializer>());