namespace CertificationApp.Tests
{
    public class TraineeTests
    {
      [Test]
        public void WhenAddWeightAndAge_ShloudConvertStringToFloatAndInt()
        {
            var weight = Trainee.AddWeight("45");
            var age = Trainee.AddAge("29");
            var trainee = new Trainee(45f, 29);
            Assert.AreEqual(trainee.Weight, weight);
            Assert.AreEqual(trainee.Age, age);
        }

        [Test]
        public void WhenAddDistanceAndTimeAndHRavg_ShloudConvertStringToFloatAndIntAndInt()
        {
            var distance = Trainee.AddDistance("26");
            var timeOfRide = Trainee.AddTimeOfRide("62");
            var HRavg = Trainee.AddHRavg("140");
            float distanceTest = 26f;
            int timeOfRideTest = 62;
            int HRavgTest = 140;
            Assert.AreEqual(distanceTest, distance);
            Assert.AreEqual(timeOfRideTest, timeOfRide);
            Assert.AreEqual(HRavgTest, HRavg);
        }

        [Test]
        public void WhenAddTraineeObject_ShloudAssessRightHRmax()
        {
            var trainee = new Trainee(75f, 35);
            int HRmax = 194;
            Assert.AreEqual(HRmax, trainee.HRMax);
        }
    }
}