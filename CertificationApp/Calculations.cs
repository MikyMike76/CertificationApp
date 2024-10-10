using System.Runtime.CompilerServices;

namespace CertificationApp
{
    public abstract class Calculations
    {
        private const float MET32 = 16.0f;
        private const float MET25_30 = 12.0f;
        private const float MET20_25 = 10.0f;                   // wyniki MET (spalone kckal/min) dla poszczególnych śr. prędkości jazdy rowerem
        private const float MET15_20 = 8.0f;
        public static bool CheckAverageHR(int HRmax, int HRavg)  //sprawdza czy tętno w trakcie treningu było w normie
        {
            bool CheckAverageHR;
            if (HRavg >= 0.55 *  HRmax && HRavg <= 0.75 * HRmax)
            {
                Console.WriteLine("Pefect heart rate range during this effort!");
                return CheckAverageHR = true;
            }
            else if (HRavg > 0.75 * HRmax)
            {
                Console.WriteLine("Too excessive physical effort!");
                return CheckAverageHR = false;
            }
            else
            {
                Console.WriteLine("Too weak physical effort!");
                return CheckAverageHR = false;
            }
        }
        public static float CountKcalBurnt (float distance,  int timeOfRide, float weight)   //liczy ilość spalonych kcal
        {
            float kcal = 0f;
            float velocity = distance / ((float)(timeOfRide/60));
            if (velocity > 30f)
            {
                kcal = timeOfRide *(MET32 * 3.5f * (weight / 200));                     //spalone kcal na podstawie wyniku MET i wagi
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
