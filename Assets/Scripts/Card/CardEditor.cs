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
            borderImage.sprite = Resources.Load<Sprite>("Sprites/Borders/" + card.borderId);
        }

        // Set card art image
        if (cardImage != null)
        {
            cardImage.sprite = Resources.Load<Sprite>("Sprites/CardArt/" + card.artId);
        }

        // Set mana image
        if (manaImage != null)
        {
            manaImage.sprite = Resources.Load<Sprite>("Sprites/Mana/" + card.manaId);
        }

        // Set text values
        nameText.SetText(card.cardName);
        typeText.SetText(card.cardType);
        toughnessText.SetText(card.toughness.ToString());
        powerText.SetText(card.power.ToString());
        descriptionText.SetText(card.cardDescription);
        costText.SetText(card.cost.ToString());
    }
}

