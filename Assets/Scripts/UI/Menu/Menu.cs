using System.Data;

using UnityEngine;
public enum MenuType
{
    MainMenu,
    DeckMenu,
    GameMenu,
    SettingsMenu,
    ExitMenu
}

public class Menu : MonoBehaviour
{
    //The MenuType determines wich menu is active. Each menu has its own class that inherits from this class.
    public MenuType MenuType { get; set; }
    public Canvas UI { get; set; }
    //instance
    public static Menu Instance { get; private set; }

    //constructor that receives menutype
    //public Menu(MenuType menuType)
    //{
    //    this.MenuType = menuType;

    //}


    //constructor that receives menutype and canvas
    public Menu(MenuType menuType, Canvas UI)
    {
        //delete all components and children of the canvas and instantiate the new menu based on the menutype
        this.MenuType = menuType;
        this.UI = UI;
        //destroy all UI components and children gameObjects but leave the canvas
        foreach (Transform child in UI.transform)
        {
            if (child.gameObject != UI.gameObject)
            {
                Destroy(child.gameObject);
            }
        }
        //create the menu based on the menutype
        Menu menu = SelectMenuToCreate();
        //set the instance of the menu
        Instance = menu;
    }

    public Menu SelectMenuToCreate()
    {
        Menu selectedMenu = null;

        // Switch to select the menu to create based on this.menuType
        switch (MenuType)
        {
            case MenuType.MainMenu:
                selectedMenu = gameObject.AddComponent<MainMenu>();
                break;
            //case MenuType.DeckMenu:
            //    selectedMenu = gameObject.AddComponent<DeckMenu>();
            //    break;
            //case MenuType.GameMenu:
            //    selectedMenu = gameObject.AddComponent<GameMenu>();
            //    break;
            //case MenuType.SettingsMenu:
            //    selectedMenu = gameObject.AddComponent<SettingsMenu>();
            //    break;
            //case MenuType.ExitMenu:
            //    selectedMenu = gameObject.AddComponent<ExitMenu>();
            //    break;
        }

        return selectedMenu;
    }


    public virtual void Start()
    {

    }
    public virtual void Update()
    {

    }
    public virtual void ChangeScene(string sceneName)
    {

    }
    public virtual void QuitGame()
    {

    }
    public virtual void SetMainCanvasPrefab()
    {

    }
    public virtual void SwapSubMenu()
    {

    }
}

   
