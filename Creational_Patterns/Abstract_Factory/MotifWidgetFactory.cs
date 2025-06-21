namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    internal class MotifWidgetFactory : IWidgetFactory
    {
        public MotifWidgetFactory()
        {
            DeclareFactoryCreation();
        }
        public void DeclareFactoryCreation()
        {
            Console.WriteLine("It's been created a concrete Motif Widget Factory");
        }
        public Window CreateWindow()
        {
            return new MotifWindow();
        }
        public ScrollBar CreateScrollBar()
        {
            return new MotifScrollBar();
        }
    }
}
