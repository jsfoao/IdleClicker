using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public float cost;
    public float prodTime;
    public float prodAmount;
    public float total;

    public Item(string _name, float _cost, float _prodTime, float _prodAmount)
    {
        this.itemName = _name;
        this.cost = _cost;
        this.prodTime = _prodTime;
        this.prodAmount = _prodAmount;
    }
}
