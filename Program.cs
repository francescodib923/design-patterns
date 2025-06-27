using DesignPatterns.Behavioural_Patterns.Memento;
using DesignPatterns.Creational_Patterns.Abstract_Factory;
using DesignPatterns.Creational_Patterns.Factory_Method;
using DesignPatterns.Structural_Patterns.Composite;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AbstractFactoryClient client = new AbstractFactoryClient(new MotifWidgetFactory());
            // client.Run();

            // MyApplication app = new MyApplication();
            // app.NewDocument("bomba");

            CareTaker<Originator> textEditor = new(new Originator("Arial", "black", "test"));
            textEditor.SetMemento();
            Thread.Sleep(2000);
            textEditor.Originator.SetText(" - other test");
            Thread.Sleep(2000);
            textEditor.SetMemento();
            Thread.Sleep(2000);
            textEditor.Originator.SetText(" - another test");

            System.Console.WriteLine($"before undo: {textEditor.Originator.Text}");
            textEditor.Undo();
            System.Console.WriteLine($"first undo: {textEditor.Originator.Text}");
            textEditor.Undo();
            System.Console.WriteLine($"second undo: {textEditor.Originator.Text}");
        }
    }
}
