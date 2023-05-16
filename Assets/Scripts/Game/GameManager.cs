using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static PlayerSettings Settings { get; private set; }
    public Canvas UI{ get; private set; }

    public enum Mode { GAME, MENU };

    public static Mode currentMode;

    private void Start()
    {
        Instance = this;
        UI = GameObject.Find("UI").GetComponent<Canvas>();
        Settings = new PlayerSettings();
        currentMode = Mode.MENU;

        if (currentMode == Mode.GAME)
            StartGameMode();
        else if (currentMode == Mode.MENU)
            StartMenuMode();
    }


    private void StartGameMode()
    {
        Game game= new Game(new Player(Settings.PlayerID), new Player(2));
        //DebugRandom(game);
    }

    private void StartMenuMode()
    {

    }

    //private void DebugRandom(Game game)
    //{
    //    game.player1.ShowPlayerInfo();
    //    game.player1.DebugPlayerCards();
    //    game.player2.DebugPlayerCards();
    //    game.player2.ShowPlayerInfo();
    //}
}
