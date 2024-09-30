namespace CertificationApp
{
    public class Trainee : TraineeBase
    {
        public override event OutcomeAddedDelegate OutcomeAdded;
        private List<float> outcomesList = new List<float>();
        private const string FileStats = "Saved_Outcomes.txt";
        public int HRMax {  get; private set; }
        public static float AddWeight(string weight)
        {
            if (float.TryParse(weight, out float result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid weight value. Use only digits. Use ',' when inputting partial value.");
            }
        }
        public static int AddAge(string age)
        {
            if (int.TryParse(age, out int result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid age value. Use only integers. Partial values are not allowed.");
            }
        }
        public Trainee(float weight, int age) : base(weight, age)
        {
            this.HRMax = (int)(210 - (0.5f * age) - (0.022f * weight) + 4); // wzór Sally-Edwards dla mężczyzn, liczy maks. dopuszczalne tętno wysiłkowe
        }
        public static float AddDistance(string distance)
        {
            if (float.TryParse(distance, out float result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid distance value. Use only digits. Use ',' when inputting partial value.");
            }
        }
        public static int AddTimeOfRide(string timeOfRide)
        {
            if (int.TryParse(timeOfRide, out int result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid Time of Ride value. Use only integers. Partial values are not allowed.");
            }
        }
        public static int AddHRavg(string HRavg)
        {
            if (int.TryParse(HRavg, out int result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid HR-average value. Use only integers. Partial values are not allowed.");
            }
        }

        public override void KcalBurnt(float distance, int timeOfRide, float weight)
        {
           float KcalBurnt = Calculations.KcalBurnt(distance, timeOfRide, weight);
            Console.WriteLine();
            Console.WriteLine("Do you want to save the outcome?");
            Console.WriteLine();
            Console.WriteLine("Write 'yes' and press 'Enter', if you want to save it or just press 'Enter' to move futher");
            string saveOutcome = Console.ReadLine();
            if (saveOutcome == "yes")
            {
                AddOutcome(KcalBurnt);
                if (OutcomeAdded != null)
                {
                    OutcomeAdded(this, new EventArgs());
                }
            }
           else { }
        }
        public override void AddOutcome(float outcome)
        {
            using (var writer = File.AppendText (FileStats))
            {
                writer.WriteLine (outcome);
            }    
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if(File.Exists ($"{FileStats}"))
            {
                using (var reader = File.OpenText($"{FileStats}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var outcome = float.Parse(line);
                        outcomesList.Add(outcome);
                        line = reader.ReadLine();
                    }
                }
                foreach (var outcome in outcomesList)
                {
                    statistics.AddOutcome(outcome);
                }
            }
            return statistics;
        }
    }
}
