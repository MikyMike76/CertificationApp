namespace CertificationApp.Tests
{
    public class TraineeTests
    {
        [Test]
        public void WhenAddTraineeObject_ShloudAssessRightHRmax()
        {
            var trainee = new Trainee(75f, 35, 65, 25f);
            int HRmax = 194;
            Assert.AreEqual(HRmax, trainee.HRMax);
        }
    }
}