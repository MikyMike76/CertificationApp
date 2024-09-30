namespace CertificationApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void WhenAddOutcome_ShloudShowCorrectResult()
        {
            var statistics = new Statistics();
            statistics.AddOutcome(4401f);
            statistics.AddOutcome(1205f);
            float maxValue = 4401f;
            float minValue = 1205f;
            float average = 2803;
            Assert.AreEqual(maxValue, statistics.MaxValue);
            Assert.AreEqual(minValue, statistics.MinValue);
            Assert.AreEqual(average, statistics.Average);
        }
    }
}