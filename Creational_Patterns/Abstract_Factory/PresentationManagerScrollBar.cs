namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    public class PresentationManagerScrollBar : ScrollBar
    {
        public PresentationManagerScrollBar() { }
        public sealed override void Scroll()
        {
            Console.WriteLine("I have scrolled a Presentation Manager ScrollBar");
        }
    }
}