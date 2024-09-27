using System.Runtime.CompilerServices;

namespace CertificationApp
{
    public abstract class Calculations
    {
        private const float MET32 = 16.0f;
        private const float MET25_30 = 12.0f;
        private const float MET20_25 = 10.0f;
        private const float MET15_20 = 8.0f;
        public static bool HRavgRangeOk (int HRmax, int HRavg)
        {
            bool HRavgRangeOk;
            if (HRavg >= 0.55 *  HRmax && HRavg <= 0.75 * HRmax)
            {
                Console.WriteLine("Pefect heart rate range during this effort!");
                return HRavgRangeOk = true;
            }
            else if (HRavg > 0.75 * HRmax)
            {
                Console.WriteLine("Too excessive physical effort!");
                return HRavgRangeOk = false;
            }
            else
            {
                Console.WriteLine("Too weak physical effort!");
                return HRavgRangeOk = false;
            }
        }
        public static float KcalBurnt (float distance,  int timeOfRide, float weight)
        {
            float kcal = 0f;
            float velocity = distance / ((float)(timeOfRide/60));
            if (velocity > 30f)
            {
                kcal = timeOfRide *(MET32 * 3.5f * (weight / 200));
                Console.WriteLine($"{kcal} kcal are burnt");
                return kcal;
            }
            else if (velocity > 25 && velocity <=30)
            {
                kcal = timeOfRide * (MET25_30 * 3.5f * (weight / 200));
                Console.WriteLine($"{kcal} kcal are burnt");
                return kcal;
            }
            else if (velocity > 20 && velocity <= 25)
            {
                kcal = timeOfRide * (MET20_25 * 3.5f * (weight / 200));
                Console.WriteLine($"{kcal} kcal are burnt");
                return kcal;
            }
            else if (velocity > 15 && velocity <= 20)
            {
                kcal = timeOfRide * (MET15_20 * 3.5f * (weight / 200));
                Console.WriteLine($"{kcal} kcal are burnt");
                return kcal;
            }
            else
            {
                throw new Exception("Non-measurable velocity!");
            }
        }
    }
}
