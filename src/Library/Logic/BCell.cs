namespace Library;

[Flags]
public enum BCell {
    Ship,
    Empty,
    Hit,
    ShipHit = Ship | Hit,
    ShipMiss = Ship | Empty,
}
