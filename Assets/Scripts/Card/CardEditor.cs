using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class CardEditor : MonoBehaviour
{
    public static void BuildCardUI(Card card, Image borderImage, Image cardImage, Image manaImage, TextMeshProUGUI nameText, TextMeshProUGUI typeText, TextMeshProUGUI powerText, TextMeshProUGUI toughnessText, TextMeshProUGUI descriptionText, TextMeshProUGUI costText)
    {
        // Set border image
        if (borderImage != null)
        {
            borderImage.sprite = card.LoadBorderSprite();
        }

        // Set card art image
        if (cardImage != null)
        {
            cardImage.sprite = card.LoadArtSprite();
        }

        // Set mana image
        if (manaImage != null)
        {
            manaImage.sprite = card.LoadManaSprite();
        }

        // Set text values
        nameText.SetText(card.cardName);
        typeText.SetText(card.cardType.ToString());
        toughnessText.SetText(card.toughness.ToString());
        powerText.SetText(card.power.ToString());
        descriptionText.SetText(card.cardDescription);
        costText.SetText(card.cost.ToString());

        // Change the font size of nameText based on cardName length
        if (card.cardName.Length <= 16)
        {
            nameText.fontSize = 13;
        }
        else
        {
            nameText.fontSize = 9;
        }
    }
}
