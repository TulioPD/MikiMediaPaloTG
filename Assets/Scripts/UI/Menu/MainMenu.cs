using TMPro;

using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : Menu
{
    private ButtonPanel buttonPanel;

    public MainMenu(MenuType menuType, Canvas mainCanvas) : base(menuType, mainCanvas)
    {
        CreateMenu();
    }

    private void Awake()
    {
        CreateMenu();
    }

    public void CreateMenu()
    {
        Debug.Log("MainMenu Start");
        Debug.Log(MenuType);
    }

    public override void Update()
    {
        // Nothing to do here
    }

    public override void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public override void QuitGame()
    {
        Application.Quit();
    }

    public override void SetMainCanvasPrefab()
    {
        UI = Resources.Load<Canvas>("Prefabs/MainMenuCanvas");
    }

    public override void SwapSubMenu()
    {
        // Implement sub-menu swapping logic here
    }
}
