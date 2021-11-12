using net6_json_test;
using BenchmarkDotNet.Running;
using System;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(BenchmarkRunner.Run<PersonSerializer>());
    }
}