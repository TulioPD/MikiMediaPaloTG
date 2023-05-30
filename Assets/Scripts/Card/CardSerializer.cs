using UnityEngine;
using System.IO;

public static class CardSerializer
{
    private static readonly string DefaultFolderPath = "Cards";
    private static readonly string FileExtension = ".json";

    public static void SaveCard(Card card)
    {
        string filePath = card.GetDefaultFilePath();

        // Convert card object to JSON
        string json = JsonUtility.ToJson(card);

        // Save JSON to file
        string fullPath = Path.Combine(Application.dataPath, filePath);
        File.WriteAllText(fullPath, json);
    }

    public static Card LoadCard(int cardId)
    {
        string filePath = GetCardFilePath(cardId);

        if (!File.Exists(filePath))
        {
            Debug.LogWarning("Card file not found: " + filePath);
            return null;
        }

        // Load JSON from file
        string json = File.ReadAllText(filePath);

        // Convert JSON to card object
        Card card = JsonUtility.FromJson<Card>(json);

        return card;
    }

    private static string GetCardFilePath(int cardId)
    {
        string fileName = string.Format("{0}", cardId);
        string filePath = Path.Combine(DefaultFolderPath, fileName + FileExtension);
        return Path.Combine(Application.dataPath, filePath);
    }
}
