namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public class PresentationManagerWidgetFactory : IWidgetFactory
    {
        public PresentationManagerWidgetFactory()
        {
            DeclareFactoryCreation();
        }
        public void DeclareFactoryCreation()
        {
            Console.WriteLine("It's been created a Concrete Presentation Manager Widget Factory");
        }
        public Window CreateWindow()
        {
            return new PresentationManagerWindow();
        }
        public ScrollBar CreateScrollBar()
        {
            return new PresentationManagerScrollBar();
        }
    }
}