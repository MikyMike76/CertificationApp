namespace CertificationApp
{
    public interface ITrainee
    {
        float Weight { get; }
        int Age { get; }
        void CountKcalBurnt(float distance, int timeOfRide, float weight);
        void AddOutcome(float outcome);
        Statistics GetStatistics();
    }
}
