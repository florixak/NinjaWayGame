using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{

    public int level;
    public int health;
    public string playerName;

    public List<Item> inventory;
    
}

[System.Serializable]
public class Item
{
    public string itemName;
    public int durability;
    public int amount;
}
