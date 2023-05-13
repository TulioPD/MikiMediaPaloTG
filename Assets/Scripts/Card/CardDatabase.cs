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
        Cards.Add(new Card(1, "Homelo Chino", 2, 1, 4, "Es Homero, pero Chino. El resto de cartas obtiene +2 de poder este turno", "Type 1 - Type 1", "b1","a2", "m2"));
        Cards.Add(new Card(2, "Goku Calvo", 2, 2, 3, "Es un Goku calvo y super serio. Me hizo demasiada gracia, as� que esta carta gana autom�ticamente la partida si pulsas las teclas Alta+F+P(TODO)", "Type 1 - Type 1", "b3","a3", "m3"));
        Cards.Add(new Card(3, "El gato Capelotas", 5, 4, 10, "Gato hijo de la grand�sima puta. Hace que todas las cartas enemigas pierdan la habilidad de bloquear durante este turno", "Type 1 - Type 1", "b4","a4", "m4"));
        Cards.Add(new Card(4, "Shrigga", 6, 9, 4, "Shrigga", "Shrigga - Shrigga", "b5","a5", "m5"));
        Cards.Add(new Card(5, "Mierd�n", 3, 10, 1, "este es Mierdon, tiene inmunodeficiencia y leishmania, y debido a que fue abusado durante los primeros 10 a�os de su vida y a su demencia, no puede acercarse a ni�os ni a abuelos y necesita comer 7 veces al d�a", "Criatura - Legendaria", "b2", "Mierdon", "m1"));
        Cards.Add(new Card(6, "El nano Regu", 3, 4, 2, "cardDescription", "cardType", "b1", "NanoRegu", "m1"));
        Cards.Add(new Card(7, "T�cnica de la garrapata b�peda", 2, 0, 0, "Atrapa a una criatura objetivo durante un turno", "Instantanea", "b5", "GarrapataBipeda", "m4"));
        Cards.Add(new Card(8, "JT", 5, 2, 8, "Tiene la habilidad de girar una carta objetivo, de la misma manera que JT gira el cuello", "Criatura", "b1", "JT", "m4"));
        Cards.Add(new Card(9, "Proteinaca", 1, 1, 1, "cardDescription", "cardType", "b3", "Proteinaca", "m4"));
        Cards.Add(new Card(10, "Probablemente la carta m�s chetada del juego", 9, 5, 10, "No s� que har�, pero espero que est� jodidamente rota de cojones", "Probablemente Dios", "b5", "npi", "m2"));
        Debug.Log("Card Database loaded");

        DontDestroyOnLoad(gameObject);

        //TODO{data serialization and access based on a single .txt/json file or based on .png card images containing the necesary information to both be saved and built from scratch}
    }
}




