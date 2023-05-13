using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public enum PlayerType
{
    player1,
    player2
}

[UnityEngine.Scripting.Preserve]
public class Player :MonoBehaviour
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public PlayerHand Hand { get; set; }
    public PlayerType PlayerType { get; internal set; }

    public Player(string name, int health, int mana, List<Card> availableCards)
    {
        Name = name;
        Health = health;
        Mana = mana;
        Hand = new PlayerHand();
    }

    public void DebugPlayerCards()
    {
        Debug.Log("Player " + Name + " cards:");
        foreach (Card card in Hand.GetCards())
        {
            Debug.Log(card.cardName);
        }
    }

    public void ShowPlayerInfo()
    {
        Debug.Log("Player " + Name + " information:");
        Debug.Log("Mana: " + Mana);
        Debug.Log("Health Points: " + Health);
        Debug.Log("Cards in hand: " + Hand.GetCards().Count);
    }


}


