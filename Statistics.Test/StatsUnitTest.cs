using System;
using Xunit;
using Statistics;
using System.Collections.Generic;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float> {98.6F, 98.2F, 97.8F, 102.2F});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 99.2F) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 102.2F) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 97.8F) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<float>());
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            // Specify the Assert statements here
            Assert.True(float.IsNaN(computedStats.average));
            Assert.True(float.IsNaN(computedStats.max));
            Assert.True(float.IsNaN(computedStats.min));
        }
    }
}
