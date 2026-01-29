namespace Oops
{
    public abstract class Animal
    {
        public string Species { get; protected set; }
        public string Name { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sounds");
        }
    }
}
