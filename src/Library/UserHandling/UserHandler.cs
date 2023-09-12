namespace Library;

public class BattleshipUserHandler {
    public int UserID1 { get; private set; }
    public int UserID2 { get; private set; }

    public BattleshipUserHandler(int id1, int id2) {
        UserID1 = id1;
        UserID2 = id2;
    }

    public async void HandleGame() {
        throw new NotImplementedException();
    }
}
