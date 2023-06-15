namespace Ship_It
{
    public class BaseballGlove : IShippable
    {
        public decimal ShipCost { get; } = 3.23M;
        public string Product { get; } = "Baseball Glove";
    }
}
