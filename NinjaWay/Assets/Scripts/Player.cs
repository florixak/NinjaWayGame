using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 0;
    public int health = 20;
    public string playerName = "Player";
    public int force = 5;
    public float walkSpeed = 5;
    public float sprintSpeed = 7;
    public bool sprinting = false;


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        Data data = SaveSystem.LoadData();

        level = data.level;
        health = data.health;
        name = data.playerName;
        force = data.force;
        walkSpeed = data.walkSpeed;
        sprintSpeed = data.sprintSpeed;

        Vector3 pos;
        pos.x = data.position[0];
        pos.y = data.position[1];
        pos.z = data.position[2];

        transform.position = pos;
    }
}
