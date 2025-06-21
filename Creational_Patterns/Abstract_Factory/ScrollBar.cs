namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public abstract class ScrollBar : IComponent
    {
        public void AnnounceComponentCreation()
        {
            Console.WriteLine("I created a scrollbar");
        }

        public virtual void Scroll()
        {
            Console.WriteLine("I scrolled a Scrollbar");
        }
    }
}
