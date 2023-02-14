using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public int force;
    public float walkSpeed;
    public float[] position;

    public PlayerData(Player player)
    {
        level = player.level;
        health = player.health;
        force = player.force;
        walkSpeed = player.walkSpeed;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}
