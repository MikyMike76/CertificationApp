namespace CertificationApp
{
    public abstract class TraineeBase : Person, ITrainee
    {
        public TraineeBase(string name, string surname, float weight, int age) : base(name, surname, weight, age)
        {
        }
        public Calculations AddDistance()
        {
            throw new NotImplementedException();
        }

        public Calculations AddHRavg()
        {
            throw new NotImplementedException();
        }

        public Calculations AddTimeOfRide()
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
