using Factory.Parts;

namespace Factory
{
    public class Car
    {
        public IBody Body;
        public IEngine Engine;
        public IInterior Interior;

        public int Mileage;

        public Car(IBody body, IEngine engine, IInterior interior)
        {
            Body = body;
            Engine = engine;
            Interior = interior;
        }
    }
}