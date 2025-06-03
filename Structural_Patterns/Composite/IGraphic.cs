namespace PatternsApp.Structural_Patterns.Composite
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGraphic
    {
        public void Draw();
        public void Add(IGraphic graphic);
        public void Remove(IGraphic graphic);
        public void GetChildren(int id);
    }
}