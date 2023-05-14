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
            borderImage.sprite = Resources.Load<Sprite>("Sprites/Borders/" + card.BorderId);
        }

        // Set card art image
        if (cardImage != null)
        {
            cardImage.sprite = Resources.Load<Sprite>("Sprites/CardArt/" + card.ArtId);
        }

        // Set mana image
        if (manaImage != null)
        {
            manaImage.sprite = Resources.Load<Sprite>("Sprites/Mana/" + card.ManaId);
        }

        // Set text values
        nameText.SetText(card.CardName);
        typeText.SetText(card.CardType.ToString());
        toughnessText.SetText(card.Toughness.ToString());
        powerText.SetText(card.Power.ToString());
        descriptionText.SetText(card.CardDescription);
        costText.SetText(card.Cost.ToString());
    }
}