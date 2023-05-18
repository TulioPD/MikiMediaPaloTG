using System.Collections;
using System.Collections.Generic;

using TMPro;

using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour
{
    public Button[] butonList { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        butonList = GetComponentsInChildren<Button>();
        TestMethod();
    }

    void TestMethod()
    {
        //for each button, debug their text
        foreach (Button button in butonList)
        {
            Debug.Log(button.GetComponentInChildren<TextMeshProUGUI>().text);
        }
    }
}
