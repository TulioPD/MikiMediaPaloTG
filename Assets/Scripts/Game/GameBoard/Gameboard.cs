using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Gameboard : MonoBehaviour
{
    public Player player1;
    public Player player2;

    

    void Start()
    {
        Transform p1Transform = transform.Find("Player 1");
        Transform p2Transform = transform.Find("Player 2");

        player1=p1Transform.GetComponent<Player>();
        player2=p2Transform.GetComponent<Player>();
    }

    void Update()
    {

    }

    private void Awake()
    {

    }
}
