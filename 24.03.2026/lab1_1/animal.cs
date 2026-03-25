namespace Animal.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} makes a sound.");
        }
         
    }
}
