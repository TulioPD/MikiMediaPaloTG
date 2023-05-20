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

    //public MenuConfig menuConfig;  // Reference to the MenuConfig asset
    //public enum Mode { GAME, MENU };
    //public static Mode currentMode;

    private void Start()
    {
        Debug.Log("Game Manager Initialized correctly");
        Instance = this;
        Settings = new PlayerSettings();
        Game game = new Game(new Player(Settings.PlayerID), new Player(2));
        //currentMode = Mode.MENU; // Set the initial mode to MENU

        // Start the menu mode
        //StartMenuMode(MenuType.MainMenu);
    }

    private void Update()
    {
        
    }

    // Switch the selected mode
    //public void SwitchCurrentMenu()
    //{
    //    currentMode = (currentMode == Mode.GAME) ? Mode.MENU : Mode.GAME;
    //}

    public void StartGameMode()
    {
        Game game = new Game(new Player(Settings.PlayerID), new Player(2));
        //DebugRandom(game);
    }

    //public void StartMenuMode(MenuType desiredMenuType)
    //{
    //    // Find the appropriate submenu configuration based on the menu type
    //    MenuConfig.SubtypeConfig config = menuConfig.subtypeConfigs.FirstOrDefault(subtype => subtype.menuType == desiredMenuType);

    //    if (config != null)
    //    {
    //        // Instantiate the submenu prefab without specifying a parent
    //        GameObject submenuPrefab = config.submenuPrefab;
    //        GameObject submenu = Instantiate(submenuPrefab);

    //        // Add necessary component to the submenu object, if needed
    //        submenu.AddComponent<MainMenu>();

    //        // Perform any other initialization or setup for the submenu
    //    }
    //    else
    //    {
    //        Debug.LogError("No configuration found for menu type: " + desiredMenuType);
    //    }
    //}
}