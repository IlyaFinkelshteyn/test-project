using Microsoft.Extensions.Configuration;
using System;

namespace TestVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //var configuration = new ConfigurationBuilder().AddEnvironmentVariables().Build();
            //Console.WriteLine("apiKey: " + configuration["apiKey"]);
            
            // https://help.appveyor.com/discussions/questions/35756-consol-color-output?mail_type=queue
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("Job is done");

        }
    }
}
