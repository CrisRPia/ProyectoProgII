namespace Library;

using System.Drawing;

public struct BattleShipsBoard {
    /// <summary>
    /// Generates a bidimensional array that represents the board state.
    /// </summary>
    public BCell[,] GetBoard()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Maps Points to ships in the board.
    /// </summary>
    private Dictionary<Point, Ship> ShipCoords { get; set; }

    /// <summary>
    /// Checks whether two ships intersect.
    /// </summary>
    public Point[] Intersection()
    {
        throw new NotImplementedException();
    }


    public int Width { get; }
    public int Height { get; }
}
