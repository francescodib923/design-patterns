namespace DesignPatterns.Structural_Patterns.Decorator
{
    internal abstract class AbstractDecorator : IVisualComponent
    {
        //Differenza tra abstract decorator "classico" e Attributo (Attributes)
        IVisualComponent VisualComponent { get; set; }
        public AbstractDecorator(IVisualComponent visualComponent)
        {
            VisualComponent = visualComponent;
        }

        public void Draw()
        {
            VisualComponent.Draw();
        }
    }
}
