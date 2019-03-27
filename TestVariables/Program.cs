using Microsoft.Extensions.Configuration;
using System;

namespace TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            Console.WriteLine("apiKey: " + configuration["apiKey"]);
        }
    }
}
