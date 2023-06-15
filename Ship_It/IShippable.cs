namespace Ship_It
{
    public interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
