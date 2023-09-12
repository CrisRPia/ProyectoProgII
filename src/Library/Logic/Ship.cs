namespace Library;

public struct Ship {
    public BCell[,] Shape { get; set; }
    public string Name { get; set; }

    public Ship(BCell[,] shape, string name) {
        Shape = shape;
        Name = name;
    }
}
