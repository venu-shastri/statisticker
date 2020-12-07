using System;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(statsComputer.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(statsComputer.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(statsComputer.min - 1.5) <= epsilon);
        }
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{});
            //All fields of computedStats (average, max, min) must be
            //Double.NaN (not-a-number), as described in
            //https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
        }
        
        public void CheckLedStatusWhenMeasurementsAreInvalid(){
            
            LedDisplay _observer1=new LedDisplay();
            Speaker _observer2=new Speaker();
            List<IInvalidMeasurementAlert> observers=new List<IInvalidMeasurementAlert> (){ _observer1,_observer2 };
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{1.5, 8.9, 3.2, 4.5});
            NotifyManager _notfyManager=new NotifyManager(observers);
            _notifyManager.Monitor(computedStats);
            Assert.True(_observer1.Status,LedDisplayhhhhhhhhhhhhhhhhhhhhhhhhhhStatus.ON);
            
        }
            
            
    }
}
