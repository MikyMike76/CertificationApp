namespace CertificationApp
{
    public interface ITrainee
    {
        string Name { get; }
        string Surname { get; }
        float Weight { get; }
        int Age { get; }
        //TraineeBase KcalBurnt(float distance, int timeOfRide, float weight);
        Statistics GetStatistics();
    }
}
