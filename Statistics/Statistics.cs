using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            return new Stats
            {
                average = numbers.Count > 0 ? numbers.Average() : float.NaN,
                max = numbers.Count > 0 ? numbers.Max() : float.NaN,
                min = numbers.Count > 0 ? numbers.Min() : float.NaN
            };
        }
    }
}
