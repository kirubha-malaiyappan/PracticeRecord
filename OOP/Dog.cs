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
        //public override void Dance()
        //{
        //    Console.WriteLine("Dancing");
        //}
        //public override void Eat()
        //{
        //    Console.WriteLine("Eating");

        //}
        //public override void Run()
        //{
        //    Console.WriteLine("Running");

        //}

    }
}
