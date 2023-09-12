namespace Library;

using System.Drawing;

public class BattleshipsBoardFactory {
    public BattleShipsBoard Board { get; set; }

    public BattleshipsBoardFactory(BattleShipsBoard board = default) {
        Board = board;
    }

    /// <summary>
    /// Place ship if valid.
    /// </summary>
    public bool Place(Ship ship, Point p, Axis vertical)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes a ship at the given coordinates.
    /// </summary>

    public void Remove() {
        throw new NotImplementedException();
    }
}
