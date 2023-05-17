using System.Linq;
using System.Net.Sockets;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public static PlayerSettings Settings { get; private set; }
    public MenuConfig menuConfig;  // Reference to the MenuConfig asset

    public Canvas UI { get; private set; }

    public enum Mode { GAME, MENU };
    public static Mode currentMode;

    private void Start()
    {
        Debug.Log("Game Manager Initialized correctly");
        Instance = this;
        UI = GameObject.Find("UI").GetComponent<Canvas>();
        Settings = new PlayerSettings();
        currentMode = Mode.MENU; // Set the initial mode to MENU

        // Start the menu mode
        StartMenuMode();
    }

    // Switch the selected mode
    public void SwitchCurrentMenu()
    {
        currentMode = (currentMode == Mode.GAME) ? Mode.MENU : Mode.GAME;
    }

    public void StartGameMode()
    {
        Game game = new Game(new Player(Settings.PlayerID), new Player(2));
        //DebugRandom(game);
    }

    private void StartMenuMode()
    {
        // Example usage of retrieving submenu prefab based on menu type
        MenuType menuType = MenuType.MainMenu;  // Replace with your desired menu type

        // Find the appropriate submenu configuration based on the menu type
        MenuConfig.SubtypeConfig config = menuConfig.subtypeConfigs.FirstOrDefault(subtype => subtype.menuType == menuType);

        if (config != null)
        {
            // Instantiate the submenu prefab and add it to the UI
            GameObject submenuPrefab = config.submenuPrefab;
            GameObject submenu = Instantiate(submenuPrefab, UI.transform);

            // Add necessary component to the submenu object, if needed
             submenu.AddComponent<MainMenu>();

            // Perform any other initialization or setup for the submenu
        }
        else
        {
            Debug.LogError("No configuration found for menu type: " + menuType);
        }
    }
}
