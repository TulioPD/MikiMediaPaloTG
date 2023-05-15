using System.Collections.Generic;

using Unity.VisualScripting;

using UnityEngine;

public class Deck
{
    public string DeckName { get; set; }
    public Player Owner { get; set; }
    public List<Card> Cards { get; set; }
    public Dictionary<int, Deck> PlayerDecks { get; set; }


    public Deck(string name, Player owner)
    {
        DeckName = name;
        Owner = owner;
        Cards = new List<Card>();
    }

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    public void RemoveCard(Card card)
    {
        Cards.Remove(card);
    }

    public Deck()
    {
        Cards = new List<Card>();
        for (int i = 0; i < 10; i++)
        {
            if (CardDatabase.Cards.Count > 0)
            {
                Cards.Add(CardDatabase.Cards[Random.Range(0, CardDatabase.Cards.Count)]);
            }
        }
    }

}
