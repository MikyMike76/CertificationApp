using System.Runtime.CompilerServices;

namespace CertificationApp
{
    public class Calculations
    {
        public float Distance { get; private set; }
        public int TimeOfRide { get; private set; }
        public int HRAvg { get; private set; }
        private const float MET32 = 16.0f;
        private const float MET25_30 = 12.0f;
        private const float MET20_25 = 10.0f;
        private const float MET15_20 = 8.0f;
        public Calculations(float distance, int timeOfRide, int HRavg)
        {
            this.Distance = distance;
            this.TimeOfRide = timeOfRide;
            this.HRAvg = HRavg;
        }
        public void AddDistance (float distance)
        {
            Distance += distance;
        }
        public void AddTimeOfRide(int timeOfRide)
        {
            TimeOfRide += timeOfRide;
        }
        public void AddHRavg(int HRavg)
        {
            HRAvg += HRavg;
        }
        public float KcalBurnt (float distance,  int timeOfRide, float weight)
        {
            float kcal = 0f;
            float velocity = distance / timeOfRide;
            if (velocity > 30f)
            {
                kcal = MET32 * 3.5f * (weight / 200);
                return kcal;
            }
            else if (velocity > 25 && velocity <=30)
            {
                kcal = MET25_30 * 3.5f * (weight / 200);
                return kcal;
            }
            else if (velocity > 20 && velocity <= 25)
            {
                kcal = MET20_25 * 3.5f * (weight / 200);
                return kcal;
            }
            else if (velocity > 15 && velocity <= 20)
            {
                kcal = MET15_20 * 3.5f * (weight / 200);
                return kcal;
            }
            else
            {
                throw new Exception("Non-measurable velocity!");
            }
        }

    }
}
