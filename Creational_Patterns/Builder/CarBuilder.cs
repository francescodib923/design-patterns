using System.Drawing;

namespace DesignPatterns.Creational_Patterns.Builder
{
    /// <summary>
    /// -- ENGLISH
    /// Separate the construction of a complex object from it's representation
    /// so that the same construction process can create different representations.
    /// -- ITALIANO
    /// Separa la costruzione di un oggetto complesso dalla sua rappresentazione
    /// così che lo stesso procedimento di costruzione può creare diverse rappresentazioni.
    /// </summary>
    internal class CarBuilder<T> : ICarBuilder<T> where T : Car, new()
    {
        private T _Car;

        public CarBuilder()
        {
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
