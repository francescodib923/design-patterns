namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public abstract class Window : IComponent
    {
        public void AnnounceComponentCreation()
        {
            Console.WriteLine("I created a Window");
        }


        public virtual void Open()
        {
            Console.WriteLine("I opened a Window");
        }
    }
}
