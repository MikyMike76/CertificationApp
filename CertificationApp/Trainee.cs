namespace CertificationApp
{
    public class Trainee : TraineeBase
    {
        public override event OutcomeAddedDelegate OutcomeAdded;
        private List<float> outcomesList = new List<float>();
        private const string FileStats = "Saved_Outcomes.txt";
        public int HRMax {  get; private set; }
        public int TimeOfRide { get; private set; }
        public float Distance { get; private set; }

        public Trainee(float weight, int age, int timeOfRide, float distance) : base(weight, age)
        {
            this.HRMax = (int)(210 - (0.5f * age) - (0.022f * weight) + 4); // wzór Sally-Edwards dla mężczyzn, liczy maks. dopuszczalne tętno wysiłkowe
            this.TimeOfRide = timeOfRide;
            this.Distance = distance;
        }
        public override void CountKcalBurnt(float distance, int timeOfRide, float weight)
        {
           float countKcalBurnt = Calculations.CountKcalBurnt(distance, timeOfRide, weight);
            Console.WriteLine();
            Console.WriteLine("Do you want to save the outcome?");
            Console.WriteLine();
            Console.WriteLine("Write 'yes' and press 'Enter', if you want to save it or just press 'Enter' to move futher");
            string saveOutcome = Console.ReadLine();
            if (saveOutcome == "yes")
            {
                AddOutcome(countKcalBurnt);
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
