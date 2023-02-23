using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackManager : MonoBehaviour
{
    public Player player;
    public Slider healthBarSlider;
    // public GameObject attacker;
    public void damagePlayer(int damage)
    {
        player.currentHealth -= damage;
        healthBarSlider.value = player.currentHealth;
    }
}
