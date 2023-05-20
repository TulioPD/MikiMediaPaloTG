using TMPro;

using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : Menu
{
    public MainMenu(MenuType menuType, Canvas mainCanvas) : base(menuType, mainCanvas)
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

    public override void QuitGame()
    {
        Debug.Log("QuitGame");
        //base.QuitGame();
    }

    public override void SetMainCanvasPrefab()
    {
        UI = Resources.Load<Canvas>("Prefabs/MainMenuCanvas");
    }

    public override void SwapSubMenu()
    {
        // Implement sub-menu swapping logic here
        Debug.Log("SwapSubMenu");
    }

    public void Play()
    {
        base.ChangeScene("Game");
        Debug.Log("A new Game has started");
    }

    public void EditPlayer()
    {
        Debug.Log("EditPlayer");
    }

    public void EditDeck()
    {
        Debug.Log("EditDeck");
    }

    public void EditSettings()
    {
        Debug.Log("EditSettings");
    }

    public void CardEditor()
    {
        Debug.Log("CardEditor");
    }
}
