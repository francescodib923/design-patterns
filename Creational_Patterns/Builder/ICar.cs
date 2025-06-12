using System.Drawing;

namespace PatternsApp.Creational_Patterns.Builder
{
    internal interface ICar
    {
        void ChangePainting(Color color);
        void StartEngine();
        void GearChange();
    }
}
