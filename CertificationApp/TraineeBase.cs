namespace CertificationApp
{
    public abstract class TraineeBase : Person, ITrainee
    {
        public TraineeBase(string name, string surname, float weight, int age) : base(name, surname, weight, age)
        {
        }
        public abstract float KcalBurnt(float distance, int timeOfRide, float weight);
        public abstract Statistics GetStatistics();
    }
}
