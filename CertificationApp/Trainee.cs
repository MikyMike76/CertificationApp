namespace CertificationApp
{
    public class Trainee : TraineeBase
    {
        public int HRMax {  get; private set; }
        public Trainee(string name, string surname, float weight, int age) : base(name, surname, weight, age)
        {
            this.HRMax = (int)(210 - (0.5f * age) - (0.022f * weight) + 4); // wzór Sally-Edwards dla mężczyzn, maks. tętno wysiłkowe
        }
        public override float KcalBurnt(float distance, int timeOfRide, float weight)
        {
           float KcalBurnt = Calculations.KcalBurnt(distance, timeOfRide, weight);
            return KcalBurnt;
        }
        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
