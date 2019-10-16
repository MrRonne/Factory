using Factory.Parts;

namespace Factory.Factories
{
    public class AUDIFactory : CarFactory
    {
        public override IBody ConstructBody() => new AUDIBody();
        public override IEngine ConstructEngine() => new AUDIEngine();
        public override IInterior ConstructInterior() => new AUDIInterior();
    }

    public class AUDIBody : IBody
    {
        public string Type => "Station wagon";
    }

    public class AUDIEngine : IEngine
    {
        public int Cylinders => 4;
    }

    public class AUDIInterior : IInterior
    {
        public string Material => "Synthetic";
    }
}