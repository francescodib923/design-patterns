using AppStudio.PatternsApp.Utility;

namespace DesignPatterns.Behavioural_Patterns.State
{
    public interface Istate
    {
        public void Handle(Context context);
    }
}
