namespace CertificationApp
{
    public class Trainee : TraineeBase
    {
        public override event OutcomeAddedDelegate OutcomeAdded;
        private const string FileStats = "Saved_Outcomes.txt";
        public int HRMax {  get; private set; }
        public Trainee(float weight, int age) : base(weight, age)
        {
            this.HRMax = (int)(210 - (0.5f * age) - (0.022f * weight) + 4); // wzór Sally-Edwards dla mężczyzn, liczy maks. tętno wysiłkowe
        }
        public override void KcalBurnt(float distance, int timeOfRide, float weight)
        {
           float KcalBurnt = Calculations.KcalBurnt(distance, timeOfRide, weight);
            Console.WriteLine();
            Console.WriteLine("Czy chcesz zapisać wynik?");
            Console.WriteLine();
            Console.WriteLine("Wpisz yes i naciśnij Enter, jeśli chcesz albo po prostu naciśnij Enter, jeśli nie chcesz");
            string save = Console.ReadLine();
            if (save == "yes")
            {
                AddOutcome(KcalBurnt);
                if (OutcomeAdded != null)
                {
                    OutcomeAdded(this, new EventArgs());
                }
            }
           else
            {

            }
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
            throw new NotImplementedException();
        }
    }
}
