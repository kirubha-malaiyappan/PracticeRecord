using C_Practice.OOP;

namespace Oops
{
    public class Dog : Animal,IActivity
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
        public void Dance()
        {
            Console.WriteLine("Dog is dancing");
        }

        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }
        

    }
}
