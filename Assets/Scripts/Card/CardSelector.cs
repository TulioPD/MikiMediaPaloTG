using System.Collections.Generic;
using System.Linq;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class CardSelector : MonoBehaviour
{
    public int selectedCardIndex;
    //La idea inicial de añadir una lista a parte en lugar de simplemente usar la de CardDatabase es porque
    //tengo pensado cambiar como funciona el acceso y serializado de datos en un futuro
    // podría ser buena idea tenerlo separado por si decido implementar colecciones o filtrados de algún tipo
    // para poder crear barajas rápidas
    public List<Card> availableCards = new List<Card>();

    public Image borderImage;
    public Image cardImage;
    public Image manaImage;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI toughnessText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI costText;
    public Card Card;
    public Canvas canvasToSreenShot;


    private void Start()
    {
        availableCards = LoadAvailableCards();
        Debug.Log($"Returned {availableCards.Count} cards");
        borderImage = gameObject.GetComponent<Image>();

        // Find the "Card Image" child object and get its Image component
        Transform cardImageTransform = transform.Find("Card Image");
        Transform manaImageTransform = transform.Find("Mana Image");
        if (cardImageTransform != null)
        {
            cardImage = cardImageTransform.GetComponent<Image>();
        }
        else
        {
            Debug.LogError("Could not find child object named \"Card Image\"");
        }
        if (manaImageTransform != null)
        {
            manaImage = manaImageTransform.GetComponent<Image>();
        }
        else
        {
            Debug.LogError("Could not find child object named \"Mana Image\"");
        }

        UpdateCardUI();
    }


    private void Update()
    {
        ChangeCard();
        if (Input.GetKeyDown(KeyCode.F))
        {
            CanvasScreenShot.OnPictureTaken += receivePNGScreenShot;
            CanvasScreenShot screenShot = GameObject.Find("Canvas").GetComponent<CanvasScreenShot>();

            screenShot.takeScreenShot(canvasToSreenShot, SCREENSHOT_TYPE.IMAGE_ONLY, false);
        }

    }

    void receivePNGScreenShot(byte[] pngArray)
    {
        Debug.Log("Picture taken");

        //Do Something With the Image (Save)
        string path = Application.persistentDataPath + "CardUIFrame_C" + selectedCardIndex.ToString() + ".png";
        System.IO.File.WriteAllBytes(path, pngArray);
        Debug.Log(path);
    }

    void ChangeCard()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // Change selected card to the left
        {
            selectedCardIndex--;
            if (selectedCardIndex < 0)
            {
                selectedCardIndex = availableCards.Count - 1;
                Card = availableCards[selectedCardIndex];
            }
            UpdateCardUI();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) // Change selected card to the right
        {
            selectedCardIndex++;
            if (selectedCardIndex >= availableCards.Count)
            {
                selectedCardIndex = 0;
                Card = availableCards[selectedCardIndex];
            }
            UpdateCardUI();
        }
    }

    private List<Card> LoadAvailableCards()
    {
        List<Card> availableCards = new List<Card>();
        //int cardsToLoad = Mathf.Min(10, CardDatabase.Cards.Count);

        for (int i = 0; i < CardDatabase.Cards.Count; i++)
        {
            availableCards.Add(CardDatabase.Cards[i]);
            availableCards[i].ShowCardInfo();
        }
        Debug.Log($"Expected {availableCards} availableCards");
        return availableCards;
    }



    private void UpdateCardUI()
    {
        if (selectedCardIndex < availableCards.Count)
        {
            Card selectedCard = availableCards[selectedCardIndex];

            CardEditor.BuildCardUI(selectedCard, borderImage, cardImage, manaImage, nameText, typeText, powerText, toughnessText, descriptionText, costText);
        }
        else
        {
            Debug.LogError($"Selected card index {selectedCardIndex} is out of range.");
        }
    }



    private void DebugCurrentAvailableCards()
    {
        string cardNames = string.Join(", ", availableCards.Select(card => card.CardName).ToArray());
        Debug.Log($"Current available cards: {cardNames}");
    }
}