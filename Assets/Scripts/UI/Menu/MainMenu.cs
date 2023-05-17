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
        //SetMainCanvasPrefab();
        //UI = Instantiate(UI);

        // Add the MainMenu component to the MainCanvas GameObject
        //UI.gameObject.AddComponent<MainMenu>();

        Debug.Log("MainMenu Start");
        Debug.Log(MenuType);

        // Find the ButtonPanel in a GameObject called "Button Panel"
        buttonPanel = GameObject.Find("Button Panel").GetComponent<ButtonPanel>();

        // Find all buttons in the button panel
        buttonPanel.butonList = buttonPanel.GetComponentsInChildren<Button>();

        // Debug the amount of buttons and their text
        Debug.Log("Button count: " + buttonPanel.butonList.Length);
        foreach (Button button in buttonPanel.butonList)
        {
            Debug.Log(button.GetComponentInChildren<TextMeshProUGUI>().text);
        }
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
