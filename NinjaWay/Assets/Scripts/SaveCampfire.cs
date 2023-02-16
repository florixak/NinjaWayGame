using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCampfire : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Saved");
        }
    }
}
