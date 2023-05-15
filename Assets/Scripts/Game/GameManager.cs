using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public enum Mode { GAME, MENU };

    public Mode currentMode;

    // references to other game systems, e.g. game board, card database, networking
    //private Gameboard gameBoard;
    //private CardDatabase cardDatabase;
    //private NetworkManager networkManager;
    //private UIManager uiManager;

    // game objects for 2 players
    //private Player player;
    //private Player player2;

    // UI prefabs for the main menu and in-game UI
    //public GameObject mainMenuPrefab;
    //public GameObject inGameUIPrefab;

    private void Start()
    {
        currentMode = Mode.GAME;
        if (currentMode == Mode.GAME)
        {
            StartGameMode();
        }
        else if (currentMode == Mode.MENU)
        {
            StartMenuMode();
        }
    }

    private void StartGameMode()
    {
        Game game= new Game(PlayerSettings.player, new Player(2));
        //Debug player info and cards 
        game.player1.ShowPlayerInfo();
        game.player1.DebugPlayerCards();
        game.player2.DebugPlayerCards();
        game.player2.ShowPlayerInfo();
    }

    private void StartMenuMode()
    {

    }
}
