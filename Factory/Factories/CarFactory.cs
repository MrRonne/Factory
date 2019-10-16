using Factory.Parts;

namespace Factory.Factories
{
    public abstract class CarFactory
    {
        public abstract IBody ConstructBody();
        public abstract IEngine ConstructEngine();
        public abstract IInterior ConstructInterior();
    }
}