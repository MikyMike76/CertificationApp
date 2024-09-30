namespace CertificationApp
{
    public class Statistics
    {
        public float MaxValue { get; private set; }
        public float MinValue { get; private set; }
        public int Count { get; private set; }
        public float Sum { get; private set; }
        
        public float Average
        {
            get
            {
               return this.Sum/this.Count;
            }
        }
        public Statistics()
        {
            this.MaxValue = float.MinValue;
            this.MinValue = float.MaxValue;
            this.Count = 0;
            this.Sum = 0;
        }
        public void AddOutcome(float value)
        {
            this.Count++;
            this.Sum += value;
            this.MaxValue = Math.Max(this.MaxValue, value);
            this.MinValue = Math.Min(this.MinValue, value);
        }

    }
}
