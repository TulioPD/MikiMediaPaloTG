using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;
[System.Serializable]

public class Card : MonoBehaviour
{
    public int id;
    public string cardName;

    public int cost;
    public int power;
    public int toughness;
    public string cardDescription;
    public string cardType;

    public string borderId;
    public string artId;
    public string manaId;


    public Card(int id, string cardName, int cost, int power, int toughness, string cardDescription, string cardType, string borderId, string artId, string manaId)
    {
        this.id = id;
        this.cardName = cardName;
        this.cost = cost;
        this.power = power;
        this.cardDescription = cardDescription;
        this.cardType = cardType;
        this.borderId = borderId;
        this.artId = artId;
        this.manaId = manaId;
        this.toughness = toughness;
    }

    //show card information 
    public void ShowCardInfo()
    {
        Debug.Log("Card Name: " + cardName);
        Debug.Log("Card Cost: " + cost);
        Debug.Log("Card Power: " + power);
        Debug.Log("Card Toughness: " + toughness);
        Debug.Log("Card Description: " + cardDescription);
        Debug.Log("Card Type: " + cardType);
        Debug.Log("Card Border: " + borderId);
        Debug.Log("Card Art: " + artId);
        Debug.Log("Card Mana: " + manaId);
    }   
}
