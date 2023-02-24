using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PressButtonText : MonoBehaviour
{
    private TextMeshProUGUI text;
    public bool isEnabled;
    public string keyToPress;
 
    void Start()
    {
        if (isEnabled)
        {
            text = GetComponent<TextMeshProUGUI>();
            text.text = "[" + keyToPress + "]";
        }
        
    }
}
