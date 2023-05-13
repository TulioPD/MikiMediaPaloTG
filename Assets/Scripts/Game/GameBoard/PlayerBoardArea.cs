using System.Collections.Generic;

public class PlayerBoardArea : Gameboard
{
    private Dictionary<Player, List<Card>> deployedCards;

    public PlayerBoardArea()
    {
        deployedCards = new Dictionary<Player, List<Card>>();
    }

    public void DeployCard(Player player, Card card)
    {
        if (!deployedCards.ContainsKey(player))
        {
            deployedCards[player] = new List<Card>();
        }

        deployedCards[player].Add(card);
    }

    public List<Card> GetDeployedCards(Player player)
    {
        if (!deployedCards.ContainsKey(player))
        {
            return new List<Card>();
        }

        return deployedCards[player];
    }
}

