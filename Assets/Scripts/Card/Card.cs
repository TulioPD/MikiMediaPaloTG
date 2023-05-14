using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

[System.Serializable]
public class Card
{
    // Properties
    public int Id { get; private set; }
    public string CardName { get; private set; }
    public int Cost { get; private set; }
    public int Power { get; private set; }
    public int Toughness { get; private set; }
    public string CardDescription { get; private set; }
    public CardType CardType { get; private set; }
    public string BorderId { get; private set; }
    public string ArtId { get; private set; }
    public string ManaId { get; private set; }

    // Constructor
    public Card(CardData cardData, CardMetadata cardMetadata)
    {
        Id = cardData.Id;
        CardName = cardData.CardName;
        Cost = cardData.Cost;
        Power = cardData.Power;
        Toughness = cardData.Toughness;
        CardDescription = cardData.CardDescription;

        CardType = cardMetadata.CardType;
        BorderId = cardMetadata.BorderId;
        ArtId = cardMetadata.ArtId;
        ManaId = cardMetadata.ManaId;
    }

    //Class constructor
    public Card(int id, string cardName, int cost, int power, int toughness, string cardDescription, CardType cardType, string borderId, string artId, string manaId)
    {
        Id = id;
        CardName = cardName;
        Cost = cost;
        Power = power;
        Toughness = toughness;
        CardDescription = cardDescription;
        CardType = cardType;
        BorderId = borderId;
        ArtId = artId;
        ManaId = manaId;
    }

    // Show card information 
    public void ShowCardInfo()
    {
        Debug.Log("Card Name: " + CardName);
        Debug.Log("Card Cost: " + Cost);
        Debug.Log("Card Power: " + Power);
        Debug.Log("Card Toughness: " + Toughness);
        Debug.Log("Card Description: " + CardDescription);
        Debug.Log("Card Type: " + CardType);
        Debug.Log("Card Border: " + BorderId);
        Debug.Log("Card Art: " + ArtId);
        Debug.Log("Card Mana: " + ManaId);
    }
}

// Enum for card types
public enum CardType
{
    Criatura,
    Hechizo,
    Encantamiento,
    Artefacto,
    Tierra
}

// Class to hold card data that can be changed during a match
public class CardData
{
    public int Id;
    public string CardName;
    public int Cost;
    public int Power;
    public int Toughness;
    public string CardDescription;
}

// Class to hold card metadata needed for UI construction
public class CardMetadata
{
    public CardType CardType;
    public string BorderId;
    public string ArtId;
    public string ManaId;
}
