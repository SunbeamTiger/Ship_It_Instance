namespace Ship_It
{
    public class Bicycles : IShippable
    {
        public decimal ShipCost { get; } = 9.50M;
        public string Product { get; } = "Bicycle";
    }
}
