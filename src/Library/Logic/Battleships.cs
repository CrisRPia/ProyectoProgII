namespace Library;

/// <summary>
/// Handles battleships game logic once the board is set.
/// </summary>
public class BGame
{
    public BBoard Board { get; set; }

    public BGame(BBoard board)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Stores the history of all player-made attacks.
    /// </summary>
    public List<Point> Attacks { get; private set; }

    /// <summary>
    /// Attack cell if not already attacked and in this.Board.
    /// </summary>
    public void Attack(Point p)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns whether all ships have been destroyed.
    /// </summary>
    public bool Won()
    {
        throw new NotImplementedException();
    }
}
