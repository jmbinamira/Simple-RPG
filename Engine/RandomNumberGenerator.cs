using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _simpleGenerator = new Random();
        public static int NumberBetween(int minValue, int maxValue)
        {
            //+1 so that decimals are rounded up
            return _simpleGenerator.Next(minValue, maxValue + 1);
        }
    }
}


/*
> Since we're not creating the class, it's a public static class. We're only calling the NumberBetween function
> In .NET framework, 2 ways to generate random numbers: Deterministic = detectable patter & Non Deterministic = not detectable.
> The one used is a simple version compared to the 2 previously mentioned.
*/