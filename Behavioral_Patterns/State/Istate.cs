using AppStudio.PatternsApp.Utility;

namespace PatternsApp.Behavioral_Patterns.State
{
    public interface Istate
    {
        public void Handle(Context context);
    }
}
