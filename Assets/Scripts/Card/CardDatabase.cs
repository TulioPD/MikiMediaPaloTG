using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    public void Awake()
    {
        Debug.Log("Card Database init");

        //Añade aquí la información de tu carta personalizada. El formato es el siguiente
        //siguiente nº, Nombre, Coste, Poder, Defensa, Descripción, tipo, 
        //nombre de archivo en carpeta Borders, nombre archivo en carpeta cardArt, 
        //combre de archivo en carpeta, nombre de archivo en carpeta Mana

        Cards.Add(new Card(0, "Gato serio", 1, 1, 1, "Es un gato muy serio. No hace absolutamente nada. Sólo estar serio", "Type 1 - Type 1", "b2","a1", "m1"));
        Cards.Add(new Card(1, "Homelo Chino", 2, 2, 4, "Es Homero, pero Chino. El resto de cartas obtiene +2 de poder este turno", "Type 1 - Type 1", "b1","a2", "m2"));
        Cards.Add(new Card(2, "Goku Calvo", 99, 99, 99, "Es un Goku calvo y super serio. Me hizo demasiada gracia, así que esta carta gana automáticamente la partida si pulsas las teclas Alta+F+P(TODO)", "Type 1 - Type 1", "b3","a3", "m3"));
        Cards.Add(new Card(3, "El gato Capelotas", 4, 4, 10, "Gato hijo de la grandísima puta. Hace que todas las cartas enemigas pierdan la habilidad de bloquear durante este turno", "Type 1 - Type 1", "b4","a4", "m4"));
        Cards.Add(new Card(4, "Shrigga", 6, 9, 4, "Shrigga", "Shrigga - Shrigga", "b5","a5", "m5"));
        Debug.Log("Card Database loaded");

        DontDestroyOnLoad(gameObject);
    }
}




