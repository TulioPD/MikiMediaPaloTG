using UnityEngine;

[CreateAssetMenu(fileName = "MenuConfig", menuName = "Menu/Subtype Configuration")]
public class MenuConfig : ScriptableObject
{
    [System.Serializable]
    public class SubtypeConfig
    {
        public MenuType menuType;
        public GameObject submenuPrefab;
    }

    public SubtypeConfig[] subtypeConfigs;
}