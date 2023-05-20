using System;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();
    private const string CardDataFilePath = "CardData.txt";


    public void Awake()
    {
        Debug.Log("Card Database init");

        // Read the card data text file
        string cardDataFilePath = "Path/To/CardData.txt";
        string[] cardDataLines = File.ReadAllLines(cardDataFilePath);

        // Read the card metadata text file
        string cardMetadataFilePath = "Path/To/CardMetadata.txt";
        string[] cardMetadataLines = File.ReadAllLines(cardMetadataFilePath);

        // Iterate through the card data and metadata lines and parse them
        for (int i = 0; i < cardDataLines.Length; i++)
        {
            string cardDataLine = cardDataLines[i];
            string cardMetadataLine = cardMetadataLines[i];

            // Parse the card data and metadata
            CardData cardData = ParseCardData(cardDataLine);
            CardMetadata cardMetadata = ParseCardMetadata(cardMetadataLine);

            // Create a new Card object using the parsed data
            Card card = new Card(cardData, cardMetadata);

            // Add the card to the list
            Cards.Add(card);
        }

        Debug.Log("Card Database loaded");


        foreach (string cardMetadataLine in cardMetadataLines)
        {
            CardMetadata cardMetadata = ParseCardMetadata(cardMetadataLine);
            if (cardMetadata != null)
            {
                Debug.Log("Successfully parsed the card metadata");
            }
        }

        foreach (string cardDataLine in cardDataLines)
        {
            CardData cardData = ParseCardData(cardDataLine);
            if (cardData != null)
            {
                Debug.Log("Successfully parsed the card data");
            }
        }


        DontDestroyOnLoad(gameObject);
    }


    private void LoadCardData()
    {
        // Load CardData from text file (example)
        string cardDataFilePath = "Path/To/Your/CardDataFile.txt";
        string[] cardDataLines = File.ReadAllLines(cardDataFilePath);

        foreach (string cardDataLine in cardDataLines)
        {
            // Parse the card data line and create a CardData object
            CardData cardData = ParseCardData(cardDataLine);

            // Add the CardData object to the Cards list
            Cards.Add(new Card(cardData, null));
        }

        // Load CardMetadata from text file
        string cardMetadataFilePath = "Path/To/Your/CardMetadataFile.txt";
        string[] cardMetadataLines = File.ReadAllLines(cardMetadataFilePath);

        int cardIndex = 0;
        foreach (string cardMetadataLine in cardMetadataLines)
        {
            // Parse the card metadata line and update the corresponding Card object
            CardMetadata cardMetadata = ParseCardMetadata(cardMetadataLine);
            if (cardIndex < Cards.Count)
            {
                Cards[cardIndex].UpdateCardMetadata(cardMetadata);
                cardIndex++;
            }
        }
    }

    private static CardData ParseCardData(string line)
    {
        string[] values = line.Split(',');

        if (values.Length < 6)
        {
            Debug.LogError("Invalid CardData line: " + line);
            return null;
        }

        int id;
        int cost;
        int power;
        int toughness;

        if (!int.TryParse(values[0], out id) ||
            !int.TryParse(values[2], out cost) ||
            !int.TryParse(values[3], out power) ||
            !int.TryParse(values[4], out toughness))
        {
            Debug.LogError("Invalid CardData values: " + line);
            return null;
        }

        string cardName = values[1];
        string cardDescription = values[5];

        return new CardData
        {
            Id = id,
            CardName = cardName,
            Cost = cost,
            Power = power,
            Toughness = toughness,
            CardDescription = cardDescription
        };
    }


    private static CardMetadata ParseCardMetadata(string line)
    {
        string[] values = line.Split(',');

        if (values.Length < 4)
        {
            Debug.LogError("Invalid CardMetadata line: " + line);
            return null;
        }

        int id;

        if (!int.TryParse(values[0], out id))
        {
            Debug.LogError("Invalid CardMetadata values: " + line);
            return null;
        }

        string cardTypeString = values[1];
        string borderId = values[2];
        string artId = values[3];
        string manaId = values[4];

        CardType cardType;
        if (!Enum.TryParse(cardTypeString, out cardType))
        {
            Debug.LogError("Invalid CardType value: " + cardTypeString);
            return null;
        }

        return new CardMetadata
        {
            CardType = cardType,
            BorderId = borderId,
            ArtId = artId,
            ManaId = manaId
        };
    }

}