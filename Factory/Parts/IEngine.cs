namespace Factory.Parts
{
    public interface IEngine : ICarPart
    {
        int Cylinders { get; }
    }
}