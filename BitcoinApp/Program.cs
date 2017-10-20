using System;
using NBitcoin;

namespace BitcoinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Key privateKey = new Key(); // generate a random private key

        }
    }
}


// How this project was created:
// dotnet new console -o BitcoinApp
// cd BitcoinApp 
// dotnet add package NBitcoin
// dotnet add package QBitninja.Client
// dotnet run