namespace DesignPatterns.Structural_Patterns.Bridge
{
    /// <summary>
    /// --- ITALIANO
    /// Separare un'astrazione dalla sua implementazione in modo che le due possano variare indipendentemente.
    /// Questa è la classe che funge da astrazione nel design pattern Bridge.
    /// --- ENGLISH
    /// Decouple an abstraction from its implementation so that the two can vary independently.
    /// 
    /// This is the abstraction class of the Bridge design pattern.
    /// </summary>
    internal abstract class Window : IWindow
    {
        private IWindowImplementor _WindowImplementor;
        public Window(IWindowImplementor windowImplementor)
        {
            _WindowImplementor = windowImplementor;
        }

        /// <summary>
        /// -- ITALIANO
        /// Simula il disegno di un rettangolo chiamando 4 volte consecutive <see cref="IWindowImplementor.DevDrawLine()"/>,
        /// per mostrare come l'astrazione:<see cref="Window"/> delega l'implementazione reale 
        /// del disegno all’oggetto implementor passato nel costruttore.
        /// -- ENGLISH
        /// Emulates the drawing of a rectangle, calling 4 times consecutively <see cref="IWindowImplementor.DevDrawLine()"/>,
        /// to show how the abstraction:<see cref="Window"/> delegates the real implementation of the drawing
        /// to the implementor object passed in the constructor. 
        /// </summary>
        public void DrawRect()
        {
            Console.WriteLine("Drawing a Rectangle...");
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();
            _WindowImplementor.DevDrawLine();

            _WindowImplementor.DevDrawText();
        }

        public void DrawText()
        {
            Console.WriteLine("Drawing Text...");
        }
    }
}
