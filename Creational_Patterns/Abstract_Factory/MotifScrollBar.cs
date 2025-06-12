namespace PatternsApp.Creational_Patterns.Abstract_Factory
{
    public class MotifScrollBar : ScrollBar
    {
        public MotifScrollBar() { }
        public sealed override void Scroll()
        {
            Console.WriteLine("I have scrolled a motif scrollbar");
        }
    }
}
