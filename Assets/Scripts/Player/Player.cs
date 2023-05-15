using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public enum PlayerType
{
    player1,
    player2
}

//[UnityEngine.Scripting.Preserve]
[System.Serializable]
public class Player 
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public PlayerHand Hand { get; set; }
    public PlayerType PlayerType { get; internal set; }
    public Deck PlayerDeck { get; set; }
    public Player(string name, int health, int mana, Deck deck)
    {
        Name = name;
        Health = health;
        Mana = mana;
        Hand = new PlayerHand();
        PlayerDeck = deck;
    }

    //empty constructor for testing
    public Player(int id)
    {
        //Name = "TestPlayer "+id;
        //Health = 20;
        //Mana = 1;
        PlayerDeck = new Deck();
        //Hand = new PlayerHand();
    }

    public void DebugPlayerCards()
    {
        Debug.Log("Player " + Name + " cards:");
        foreach (Card card in this.PlayerDeck.Cards)
        {
            Debug.Log(card.CardName);
        }
    }

    public void ShowPlayerInfo()
    {
        Debug.Log("Player " + Name + " information:");
        Debug.Log("Mana: " + Mana);
        Debug.Log("Health Points: " + Health);
        //Debug.Log("Cards in hand: " + Hand.GetCards().Count);
        Debug.Log("Deck name: " + PlayerDeck.DeckName);
    }
}