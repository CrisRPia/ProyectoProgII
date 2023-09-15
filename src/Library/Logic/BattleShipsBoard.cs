namespace Library;

/// <summary>
/// Represents the board of a game of Battleships.
/// </summary>
public struct BBoard
{
    /// <summary>
    /// Calculates the value that should be at the position.
    /// </summary>
    public BCell this[Point p]
    {
        get => this[p.X, p.Y];
    }

    /// <summary>
    /// Calculates the value that should be at the position.
    /// </summary>
    public BCell this[int x, int y]
    {
        get => throw new NotImplementedException();
    }

    public BCell[,] ToArray() => throw new NotImplementedException();

    /// <summary>
    /// Maps Points to ships in the board.
    /// </summary>
    private Dictionary<Point, Ship> ShipCoords { get; set; }

    /// <summary>
    /// Checks whether two ships intersect.
    /// </summary>
    public Point[] Intersection() => throw new NotImplementedException();

    public int Width { get; }
    public int Height { get; }
}
