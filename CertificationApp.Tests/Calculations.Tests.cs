namespace CertificationApp.Tests
{
    public class CalculationsTests
    {
      [Test]
        public void WhenUseCountKcalBurnt_ShloudShowCorrectResult()
        {
            float kcalBurnt = Calculations.CountKcalBurnt(26f, 62, 85f);
            float kcalRounded = (float)Math.Round(kcalBurnt, 2);
            float kcalBurntTest = 1106.70f;
            Assert.AreEqual(kcalBurntTest, kcalRounded);
        }
    }
}