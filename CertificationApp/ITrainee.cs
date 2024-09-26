namespace CertificationApp
{
    public interface ITrainee
    {
        string Name { get; }
        string Surname { get; }
        float Weight { get; }
        int Age { get; }
        Calculations AddDistance();
        Calculations AddTimeOfRide();
        Calculations AddHRavg();
        Statistics GetStatistics();
    }
}
