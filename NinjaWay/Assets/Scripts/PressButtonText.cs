using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PressButtonText : MonoBehaviour
{
    private TextMeshProUGUI text;
    public string keyToPress;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = "[ " + keyToPress + " ]";
    }
}
