using System.Collections.Generic;

public class Game
{
    public Player player1;
    public Player player2;

    public Gameboard gameboard;

    public Game(Player player1, Player player2)
    {
        this.player1 = player1;
        this.player2 = player2;
        // Set player types
        player1.PlayerType = PlayerType.player1;
        player2.PlayerType = PlayerType.player2;
    }

    public void StartGame()
    {
        //TODO: Implement game logic
    }
}
