namespace Ship_It
{
    public class Crackers : IShippable
    {
        public decimal ShipCost { get; } = 0.57M;
        public string Product { get; } = "Crackers";
    }
}
