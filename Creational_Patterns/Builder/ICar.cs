using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Builder
{
    internal interface ICar
    {
        void ChangePainting(Color color);
        void StartEngine();
        void GearChange();
    }
}
