namespace CertificationApp
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public float Weight { get; private set; }
        public int Age { get; private set; }

        public Person(string name, string surname, float weight, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Weight = weight;
            this.Age = age;
        }
    }
}
