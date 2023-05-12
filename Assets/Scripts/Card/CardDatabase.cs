using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    public void Awake()
    {
        Debug.Log("Card Database init");

        //Aqu� deber�s a�adir la informaci�n de la carta, como se especifica en la documentaci�n.
        //Simplemente copia y pega la siguiente linea sin el "//" inicial y cambia los valores entre cada coma (Si hay comillas dobles, escribe el valor dentro de estas comillas)
        //No te olvides tambi�n de cambiar el valor del Id de la carta al siguiente valor num�rico en la lista.
        //Cards.Add(new Card(id, "cardName", cost, power, toughness, "cardDescription", "cardType", "borderId", "artId", "manaId"));
        Cards.Add(new Card(0, "Gato serio", 1, 1, 1, "Es un gato muy serio. No hace absolutamente nada. S�lo estar serio", "Type 1 - Type 1", "b2","a1", "m1"));
        Cards.Add(new Card(1, "Homelo Chino", 2, 2, 4, "Es Homero, pero Chino. El resto de cartas obtiene +2 de poder este turno", "Type 1 - Type 1", "b1","a2", "m2"));
        Cards.Add(new Card(2, "Goku Calvo", 99, 99, 99, "Es un Goku calvo y super serio. Me hizo demasiada gracia, as� que esta carta gana autom�ticamente la partida si pulsas las teclas Alta+F+P(TODO)", "Type 1 - Type 1", "b3","a3", "m3"));
        Cards.Add(new Card(3, "El gato Capelotas", 4, 4, 10, "Gato hijo de la grand�sima puta. Hace que todas las cartas enemigas pierdan la habilidad de bloquear durante este turno", "Type 1 - Type 1", "b4","a4", "m4"));
        Cards.Add(new Card(4, "Shrigga", 6, 9, 4, "Shrigga", "Shrigga - Shrigga", "b5","a5", "m5"));
        Debug.Log("Card Database loaded");

        DontDestroyOnLoad(gameObject);

        //TODO{data serialization and access based on a single .txt/json file or based on .png card images containing the necesary information to both be saved and built from scratch}
    }
}




