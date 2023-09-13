namespace Library;

/// <summary>
/// Represents a cell in a Battleships board.
/// </summary>
[Flags]
public enum BCell {
    Ship,
    Empty,
    Hit,
    ShipHit = Ship | Hit,
    ShipMiss = Ship | Empty,
}
