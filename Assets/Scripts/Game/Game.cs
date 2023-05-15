using System.Collections.Generic;

public class Game
{
    public Player player1;
    public Player player2;

    public Game(Deck player1Deck, Deck player2Deck)
    {
        player1 = new Player("Player 1", 20, 0, player1Deck);
        player2 = new Player("Player 2", 20, 0, player2Deck);

        // Set player types
        player1.PlayerType = PlayerType.player1;
        player2.PlayerType = PlayerType.player2;
    }

    public void StartGame()
    {
        //TODO: Implement game logic
    }
}
