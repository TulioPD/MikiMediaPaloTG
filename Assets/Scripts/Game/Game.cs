using System.Collections.Generic;
using System.Diagnostics;

using static UnityEditor.Experimental.GraphView.GraphView;

public class Game
{
    public Player[] Players;

    public Game()
    {
        // Initialize players
        Players = new Player[2];
        Players[0] = new Player("Player 1",20,10,CardDatabase.Cards);
        Players[1] = new Player("Player 2", 20, 10, CardDatabase.Cards);
        
        // Draw 5 random cards for each player from the CardDatabase
        List<Card> availableCards = new List<Card>(CardDatabase.Cards);
        for (int i = 0; i < Players.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Card drawnCard = Players[i].Hand.DrawRandomCard(availableCards);
                Players[i].Hand.AddCard(drawnCard);
            }
            ShowInformation(Players[i]);
            
        }


    }

    public void ShowInformation(Player player)
    {
        player.ShowPlayerInfo();
        player.DebugPlayerCards();
    }
}
