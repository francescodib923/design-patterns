namespace DesignPatterns.Creational_Patterns.Abstract_Factory
{
    public interface IWidgetFactory
    {
        public void DeclareFactoryCreation();
        public Window CreateWindow();
        public ScrollBar CreateScrollBar();
    }
}
