using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Gameboard : MonoBehaviour
{
    public Player player1;
    public Player player2;



    

    void Start()
    {
        Transform p1Transform = transform.Find("Player 1");
        Transform p2Transform = transform.Find("Player 2");

        player1=p1Transform.GetComponent<Player>();
        player2=p2Transform.GetComponent<Player>();

        player1.PlayerType = PlayerType.player1;
        player2.PlayerType = PlayerType.player2;

    }

    private Dictionary<Card, Dictionary<string, object>> player1DeployedCards = new Dictionary<Card, Dictionary<string, object>>();
    private Dictionary<Card, Dictionary<string, object>> player2DeployedCards = new Dictionary<Card, Dictionary<string, object>>();
    private Dictionary<Player, Dictionary<Card, Dictionary<string, object>>> playerDeployedCards = new Dictionary<Player, Dictionary<Card, Dictionary<string, object>>>();

    public void DeployCard(Card card, Player player)
    {
        Dictionary<Card, Dictionary<string, object>> deployedCards;
        if (player.Equals(PlayerType.player1))
        {
            deployedCards = player1DeployedCards;
        }
        else
        {
            deployedCards = player2DeployedCards;
        }

        deployedCards[card] = new Dictionary<string, object>();
        // set up the card information, e.g. health points, mana cost, etc.

        playerDeployedCards[player] = deployedCards;
    }
}
