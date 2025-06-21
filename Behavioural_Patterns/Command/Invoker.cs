namespace DesignPatterns.Behavioural_Patterns.Command
{
    /// <summary>
    /// Partecipant for Command Pattern
    /// Asks the command to carry out the request (ex: a Menu item)
    /// </summary>
    class Invoker
    {
        public ICommand[] Commands;

        public Invoker(params ICommand[] commands)
        {
            Commands = commands;
        }

        public void Invoke()
        {
            foreach (var item in Commands)
            {
                item.Execute();
            }
        }
    }
}
