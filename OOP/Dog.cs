namespace Oops
{
    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            Species = "Mammal";
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine("Barks");
        }
    }
}
