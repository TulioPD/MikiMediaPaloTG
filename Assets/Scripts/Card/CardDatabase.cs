using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> Cards = new List<Card>();

    public void Awake()
    {
        Debug.Log("Card Database init");

        //Aquí deberás añadir la información de la carta, como se especifica en la documentación.
        //Simplemente copia y pega la siguiente linea sin el "//" inicial y cambia los valores entre cada coma (Si hay comillas dobles, escribe el valor dentro de estas comillas)
        //No te olvides también de cambiar el valor del Id de la carta al siguiente valor numérico en la lista.
        //Cards.Add(new Card(id, "cardName", cost, power, toughness, "cardDescription", "cardType", "borderId", "artId", "manaId"));
        Cards.Add(new Card(0, "Gato serio", 1, 1, 1, "Es un gato muy serio. No hace absolutamente nada. Sólo estar serio", CardType.Criatura, "b2","a1", "m1"));
        Cards.Add(new Card(1, "Homelo Chino", 2, 1, 4, "Es Homero, pero Chino. El resto de cartas obtiene +2 de poder este turno", CardType.Criatura, "b1","a2", "m2"));
        Cards.Add(new Card(2, "Goku Calvo", 2, 2, 3, "Es un Goku calvo y super serio. Me hizo demasiada gracia, así que esta carta gana automáticamente la partida si pulsas las teclas Alta+F+P(TODO)", CardType.Criatura, "b3","a3", "m3"));
        Cards.Add(new Card(3, "El gato Capelotas", 5, 4, 10, "Gato hijo de la grandísima puta. Hace que todas las cartas enemigas pierdan la habilidad de bloquear durante este turno", CardType.Criatura, "b4","a4", "m4"));
        Cards.Add(new Card(4, "Shrigga", 6, 9, 4, "Shrigga", CardType.Criatura, "b5","a5", "m5"));
        Cards.Add(new Card(5, "Mierdón", 3, 10, 1, "este es Mierdon, tiene inmunodeficiencia y leishmania, y debido a que fue abusado durante los primeros 10 años de su vida y a su demencia, no puede acercarse a niños ni a abuelos y necesita comer 7 veces al día", CardType.Criatura, "b2", "Mierdon", "m1"));
        Cards.Add(new Card(6, "El nano Regu", 3, 4, 2, "cardDescription", CardType.Criatura, "b1", "NanoRegu", "m1"));
        Cards.Add(new Card(7, "Técnica de la garrapata bípeda", 2, 0, 0, "Atrapa a una criatura objetivo durante un turno", CardType.Hechizo, "b5", "GarrapataBipeda", "m4"));
        Cards.Add(new Card(8, "JT", 5, 2, 8, "Tiene la habilidad de girar una carta objetivo, de la misma manera que JT gira el cuello", CardType.Encantamiento, "b1", "JT", "m4"));
        Cards.Add(new Card(9, "Proteinaca", 1, 1, 1, "cardDescription", CardType.Artefacto, "b3", "Proteinaca", "m4"));
        Cards.Add(new Card(10, "Probablemente Dios", 9, 5, 10, "No sé que hará, pero espero que esté jodidamente rota de cojones", CardType.Criatura, "b7", "npi", "m2"));
        Cards.Add(new Card(11, "Carlos salvaje aparece", 1, 1, 1, "Si no hay criaturas del tipo Carlos en el campo, invoca uno de tu mano sin coste alguno", CardType.Criatura, "b3", "CarlosAparece", "m2"));
        Cards.Add(new Card(12, "Comunismo", 1, 1, 1, "Niega efectos adversos si hay cartas de con el nombre Ruso en tu campo", CardType.Hechizo, "b7", "Comunismo", "m2"));
        Cards.Add(new Card(13, "Choraza", 1, 1, 1, "Si tienes una tierra Santiago en el campo, suma un punto de maná", CardType.Encantamiento, "b7", "Choraza", "m2"));
        Cards.Add(new Card(14, "Santiago", 1, 1, 1, "Está muy lejos a pié", CardType.Tierra, "b7", "Santiago", "m2"));
        Cards.Add(new Card(15, "Tripis", 1, 1, 1, "Voltea una de las cartas en el campo de tu adversario", CardType.Hechizo, "b7", "Tripis", "m2"));
        Cards.Add(new Card(16, "One Piece 2", 1, 1, 1, "Si un monstruo de tipo Micky Media, añade dos toquens al campo sin coste alguno", CardType.Hechizo, "b7", "OP2", "m2"));
        Debug.Log("Card Database loaded");

        DontDestroyOnLoad(gameObject);

        //TODO{data serialization and access based on a single .txt/json file or based on .png card images containing the necesary information to both be saved and built from scratch}
    }
}