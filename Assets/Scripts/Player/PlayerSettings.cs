using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerSettings
{
    //This class contains useful Player information that can be accesed from the GameManager and modified if gameMode=Mode.MENU It contains a Player, and a Deck
    public static Player player;

    public static Deck selectedDeck;

    //constructor
    static PlayerSettings()
    {
        player = new Player(1);
        selectedDeck = player.PlayerDeck;
    }
}
