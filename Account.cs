namespace knightmoves;

public class Account {
    public string Name { get; set; }

    private string ChangeName(string newName) {
        Name = newName;
        return newName;
    }
}

