using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Mode { GAME, MENU };

    public Mode currentMode;

    // references to other game systems, e.g. game board, card database, networking
    private Gameboard gameBoard;
    private CardDatabase cardDatabase;
    //private NetworkManager networkManager;
    //private UIManager uiManager;

    // game objects for 2 players
    private Player player1;
    private Player player2;

    // UI prefabs for the main menu and in-game UI
    public GameObject mainMenuPrefab;
    public GameObject inGameUIPrefab;

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
        player1 = new Player(1);
        player2 = new Player(2);
        Game game= new Game(player1, player2);
        //Debug player info and cards 
        game.player1.ShowPlayerInfo();
        game.player1.DebugPlayerCards();
        game.player2.DebugPlayerCards();
        game.player2.ShowPlayerInfo();


        //// create the game board and card database
        //gameBoard = new GameBoard();
        //cardDatabase = new CardDatabase();

        //// create 2 players and give them a deck
        //Deck player1Deck = // get the selected deck for player 1
        //Deck player2Deck = // get the selected deck for player 2

        //player1 = new Player(player1Deck);
        //player2 = new Player(player2Deck);

        //// create the UI and start the game
        //uiManager = Instantiate(inGameUIPrefab).GetComponent<UIManager>();
        //uiManager.SetPlayers(player1, player2);

        //// start the game loop
        //StartCoroutine(GameLoop());
    }

    private void StartMenuMode()
    {
        //// create the UI for the main menu
        //uiManager = Instantiate(mainMenuPrefab).GetComponent<UIManager>();
        //uiManager.SetGameManager(this);
    }

    //private IEnumerator GameLoop()
    //{
    //    // TODO: implement game loop
    //}
}
