using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    private Slider slider;
    public Player player;
    // public Gradient gradient;
    
    void Start()
    {
        slider = GetComponent<Slider>();

        slider.maxValue = player.maxHealth;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
