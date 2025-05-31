using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsApp.Creational_Patterns.Builder
{
    internal class CarBuilder<T> : ICarBuilder<T> where T : Car, new()
    {
        private T _Car;

        public CarBuilder()
        {
            Console.WriteLine("|___| BUILDER |___|");
            _Car = new T();
            Console.WriteLine($"It's been created a {_Car.GetType().Name} builder");
        }
        public T BuildCar()
        {
            return _Car;
        }
        public CarBuilder<T> SetPainting(Color color)
        {
            _Car?.ChangePainting(color);
            return this;
        }
        public CarBuilder<T> SetHorsePower(int hp) 
        {
            _Car?.ChangeHorsePower(hp);
            return this;
        }
    }
}
