namespace CertificationApp
{
    public class Person
    {
        public float Weight { get; private set; }
        public int Age { get; private set; }

        public Person(float weight, int age)
        {
            this.Weight = weight;
            this.Age = age;
        }
    }
}
