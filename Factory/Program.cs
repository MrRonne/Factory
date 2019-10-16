using System;
using Factory.Factories;
using Factory.Parts;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            CarFactory factory = null;
            if (rnd.Next(0, 1) == 0)
                factory = new BMWFactory();
            else
                factory = new AUDIFactory();
            Assemble(factory.ConstructBody(), factory.ConstructEngine(), factory.ConstructInterior());
        }

        static Car Assemble(IBody body, IEngine engine, IInterior interior)
        {
            return new Car(body, engine, interior);
        }
    }
}