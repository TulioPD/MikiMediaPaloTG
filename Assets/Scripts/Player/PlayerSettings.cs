using System.IO;

using UnityEngine;

public class PlayerSettings
{
    public int PlayerID { get; set; } = 69;
    private static readonly string filePath = "Assets/Resources/PlayerSettings.txt";
    private int SelectedDeckID { get; set; } = 0;
    public string PlayerName { get; set; } = "Demo Player UwU";

    public PlayerSettings()
    {
        if (CheckForFilePath())
        {
            LoadPlayerSettings();
        }
        else
        {
            CreatePlayerSettings();
        }
    }

    private static bool CheckForFilePath()
    {
        return File.Exists(filePath);
    }

    private void OverwritePlayerSettings()
    {
        File.WriteAllText(filePath, string.Empty);
        File.WriteAllText(filePath, "PlayerId: " + PlayerID + "\n" + "SelectedDeckId: " + SelectedDeckID);
    }

    private void CreatePlayerSettings()
    {
        File.WriteAllText(filePath, "PlayerId: " + PlayerID + "\n" + "SelectedDeckId: " + SelectedDeckID);
    }

    private void LoadPlayerSettings()
    {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            if (line.Contains("PlayerId"))
            {
                string[] splitLine = line.Split(':');
                PlayerID = int.Parse(splitLine[1]);
            }
            if (line.Contains("SelectedDeckId"))
            {
                string[] splitLine = line.Split(':');
                SelectedDeckID = int.Parse(splitLine[1]);
            }
        }
    }

    private void ModifyPlayerSettings(string value, string setting)
    {
        string[] lines = File.ReadAllLines(filePath);
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].Contains(setting))
            {
                lines[i] = setting + ": " + value;
            }
        }
        File.WriteAllLines(filePath, lines);
    }

    // Note: Commenting out the DebugPlayerSettings method for the final version
    // private void DebugPlayerSettings()
    // {
    //     Debug.Log("PlayerId: " + PlayerID);
    //     Debug.Log("SelectedDeckId: " + SelectedDeckID);
    // }
}
