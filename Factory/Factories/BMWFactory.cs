using Factory.Parts;

namespace Factory.Factories
{
    public class BMWFactory : CarFactory
    {
        public override IBody ConstructBody() => new BMWBody();
        public override IEngine ConstructEngine() =>new BMWEngine();
        public override IInterior ConstructInterior() => new BMWInterior();
    }

    public class BMWBody : IBody
    {
        public string Type => "Hatchback";
    }

    public class BMWEngine : IEngine
    {
        public int Cylinders => 8;
    }

    public class BMWInterior : IInterior
    {
        public string Material => "Leather";
    }
}