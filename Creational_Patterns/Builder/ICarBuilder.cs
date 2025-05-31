using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Builder
{
    internal interface ICarBuilder<T> where T : ICar
    {
        T BuildCar();
    }
}
