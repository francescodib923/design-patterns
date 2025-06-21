﻿namespace DesignPatterns.Creational_Patterns.Prototype
{
    /// <summary>
    /// -- ENGLISH
    /// Sepecify the kinds of objects to create using a prototypical instance,
    /// and create new objects by copying the prototype.
    /// -- ITALIANO
    /// Specifica i tipi di oggetti da creare usando un'istanza prototipica,
    /// e crea nuovi oggetti copiando il prototipo.
    /// </summary>
    internal abstract class Shape : ICloneable, IEquatable<Shape>
    {
        public string Id { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public abstract object Clone();
        public abstract object Clone(string id);

        public void Draw()
        {
            if (Id.Equals(string.Empty.Trim())) { throw new InvalidOperationException(); }
            if (Type.Equals(string.Empty.Trim())) { throw new InvalidOperationException(); }
            Console.WriteLine($"Drawing a {Type} with Id: {Id}");
        }

        public bool Equals(Shape? other)
        {
            if (other == null)
            {
                Console.WriteLine("Shape has not been instanced yet");
                return false;
            }
            if (other.Type == this.Type)
            {
                Console.WriteLine($"{other.Type} with id {other.Id} " +
                                  $"is the same shape of {this.Type} with id {this.Id}");
                return true;
            }
            Console.WriteLine($"{other.Type} with id {other.Id} " +
                                  $"is NOT the same shape of {this.Type} with id {this.Id}");
            return false;
        }
    }
}
