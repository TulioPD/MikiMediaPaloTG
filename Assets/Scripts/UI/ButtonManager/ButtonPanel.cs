using System.Collections;
using System.Collections.Generic;

using TMPro;

using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour
{
    public Button[] butonList;
    // Start is called before the first frame update
    void Start()
    {
        butonList = GetComponentsInChildren<Button>();
    }
}
