using System;
using System.IO;

using UnityEngine;

public enum CardType
{
    Creature,
    Spell,
    Enchantment,
    Artifact
}

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
[Serializable]
public class Card : ScriptableObject
{
    // Properties
    public int cardId;
    public string cardName;
    public int cost;
    public int power;
    public int toughness;
    public string cardDescription;
    public CardType cardType;
    public string borderSpritePath;
    public string artSpritePath;
    public string manaSpritePath;

    // Default file paths for loading and saving
    private static readonly string DefaultFolderPath = "Cards";
    private static readonly string FileExtension = ".json";

    public string GetDefaultFilePath()
    {
        string fileName = string.Format("Card_{0}", cardId);
        return Path.Combine(DefaultFolderPath, fileName + FileExtension);
    }

    // Load sprites using the stored paths
    public Sprite LoadBorderSprite()
    {
        return Resources.Load<Sprite>(GetSpritePath("Borders", borderSpritePath));
    }

    public Sprite LoadArtSprite()
    {
        return Resources.Load<Sprite>(GetSpritePath("CardArt", artSpritePath));
    }

    public Sprite LoadManaSprite()
    {
        return Resources.Load<Sprite>(GetSpritePath("Mana", manaSpritePath));
    }

    private string GetSpritePath(string folderName, string spritePath)
    {
        string path = string.Format("Sprites/{0}/{1}", folderName, spritePath);
        return path;
    }

    //Debug method

    public void PrintCard()
    {
        Debug.Log("Card ID: " + cardId);
        Debug.Log("Card Name: " + cardName);
        Debug.Log("Card Cost: " + cost);
        Debug.Log("Card Power: " + power);
        Debug.Log("Card Toughness: " + toughness);
        Debug.Log("Card Description: " + cardDescription);
        Debug.Log("Card Type: " + cardType);
        Debug.Log("Card Border Sprite Path: " + borderSpritePath);
        Debug.Log("Card Art Sprite Path: " + artSpritePath);
        Debug.Log("Card Mana Sprite Path: " + manaSpritePath);
    }
}
