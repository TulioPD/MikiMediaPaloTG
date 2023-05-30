using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class CardSelector : MonoBehaviour
{
    public List<Card> availableCards = new List<Card>();
    public int selectedCardIndex;

    public Image borderImage;
    public Image cardImage;
    public Image manaImage;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI toughnessText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI costText;

    private void Start()
    {
        availableCards = LoadAvailableCards();
        UpdateCardUI();
    }

    private List<Card> LoadAvailableCards()
    {
        List<Card> cards = new List<Card>();

        // Load JSON files from a specified directory
        string jsonDirectoryPath = Path.Combine(Application.dataPath, "Cards").Replace("\\", "/");
        // Debug jsonDirectoryPath
        Debug.Log(jsonDirectoryPath);
        string[] jsonFiles = Directory.GetFiles(jsonDirectoryPath, "*.json");

        foreach (string jsonFilePath in jsonFiles)
        {
            string jsonContent = File.ReadAllText(jsonFilePath);
            Card card = JsonUtility.FromJson<Card>(jsonContent);
            cards.Add(card);
        }

        return cards;
    }



    private void OnEnable()
    {
        // Enable input actions
        InputSystem.EnableDevice(Mouse.current);
        InputSystem.EnableDevice(Keyboard.current);
    }

    private void OnDisable()
    {
        // Disable input actions
        InputSystem.DisableDevice(Mouse.current);
        InputSystem.DisableDevice(Keyboard.current);
    }

    private void Update()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame) // Change selected card to the left
        {
            selectedCardIndex--;
            if (selectedCardIndex < 0)
                selectedCardIndex = availableCards.Count - 1;
            UpdateCardUI();
        }
        else if (Keyboard.current.rightArrowKey.wasPressedThisFrame) // Change selected card to the right
        {
            selectedCardIndex++;
            if (selectedCardIndex >= availableCards.Count)
                selectedCardIndex = 0;
            UpdateCardUI();
        }
    }

    private void UpdateCardUI()
    {
        if (selectedCardIndex < availableCards.Count)
        {
            Card selectedCard = availableCards[selectedCardIndex];
            CardEditor.BuildCardUI(selectedCard, borderImage, cardImage, manaImage, nameText, typeText, powerText, toughnessText, descriptionText, costText);
        }
    }
}
