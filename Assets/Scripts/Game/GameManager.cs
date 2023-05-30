using System.Linq;
using System.Net.Sockets;

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static PlayerSettings Settings { get; private set; }
    public static Game Game { get; private set; }
    public static TurnManager TurnManager { get; private set; }
    
    private void Start()
    {
        Debug.Log("Game Manager Initialized correctly");
        Instance = this;
        Settings = new PlayerSettings();
        Game game = new Game(new Player(Settings.PlayerID), new Player(2));
    }

    private void Update()
    {
        
    }

    public void StartGameMode()
    {
        Game game = new Game(new Player(Settings.PlayerID), new Player(2));
        //DebugRandom(game);
    }
}