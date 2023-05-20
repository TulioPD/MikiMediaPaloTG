using System.Collections.Generic;

using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    protected List<Card> cards = new List<Card>();

    public void AddCard(Card card)
    {
        cards.Add(card);
    }

    public void RemoveCard(Card card)
    {
        cards.Remove(card);
    }

    public bool ContainsCard(Card card)
    {
        return cards.Contains(card);
    }

    public int GetCardCount()
    {
        return cards.Count;
    }

    public List<Card> GetCards()
    {
        return cards;
    }

    public Card DrawRandomCard(List<Card> availableCards)
    {
        if (availableCards.Count == 0)
        {
            return null;
        }

        int randomIndex = UnityEngine.Random.Range(0, availableCards.Count);
        Card drawnCard = availableCards[randomIndex];
        availableCards.RemoveAt(randomIndex);

        return drawnCard;
    }
}
