using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public static List<Item> itemList = new List<Item>();

    void Awake()
    {
        itemList.Add(new Item(0, "None", "None"));
        itemList.Add(new Item(1, "Cube", "It is item"));
        itemList.Add(new Item(2, "Flash Light", "It is item"));
        itemList.Add(new Item(3, "Scissors", "It is item"));
        itemList.Add(new Item(4, "Knife", "It is item"));
        itemList.Add(new Item(5, "String", "It is item"));
        itemList.Add(new Item(6, "Lighter", "It is item"));
    }
}
