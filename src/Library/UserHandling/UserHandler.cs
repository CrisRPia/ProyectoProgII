namespace Library;

public class BattleshipUserHandler {
    public int UserID1 { get; private set; }
    public int UserID2 { get; private set; }

    public BattleshipUserHandler(int id1, int id2) {
        UserID1 = id1;
        UserID2 = id2;
    }

    /// <summary>
    /// Handles the main game loop between two players.
    /// </summary>
    public async void HandleGame() {
        // This is done to prevent the warning.
        await Task.Delay(1);
        throw new NotImplementedException();
    }
}
