namespace PatternsApp.Creational_Patterns.Prototype
{
    internal class Circle : Shape
    {
        public Circle(string id)
        {
            base.Type = "Circle";
            base.Id = id;
        }
        public override object Clone()
        {
            Shape shape = (Shape)this.MemberwiseClone();
            return shape;
        }
        public override object Clone(string id)
        {
            Shape shape = (Shape)this.MemberwiseClone();
            shape.Id = id;
            return shape; //this will create a shallow copy of shape instance
        }
    }
}
