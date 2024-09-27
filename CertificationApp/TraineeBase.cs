namespace CertificationApp
{
    public abstract class TraineeBase : Person, ITrainee
    {
        public delegate void OutcomeAddedDelegate(object sender, EventArgs args);
        public abstract event OutcomeAddedDelegate OutcomeAdded;
        public void OutcomeAddedMessage(object sender, EventArgs args)
        {
            Console.WriteLine("Wynik spalonych kcal zapisano w pliku");
        }
        public TraineeBase(float weight, int age) : base(weight, age)
        {
            this.OutcomeAdded += OutcomeAddedMessage;
        }
        public abstract void KcalBurnt(float distance, int timeOfRide, float weight);
        public abstract void AddOutcome(float outcome);
        public abstract Statistics GetStatistics();
    }
}
