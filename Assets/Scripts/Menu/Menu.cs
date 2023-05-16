public enum MenuType
{
    MainMenu,
    DeckMenu,
    GameMenu,
    SettingsMenu,
    ExitMenu
}

public class Menu
{
    public MenuType MenuType { get; set; }
}
