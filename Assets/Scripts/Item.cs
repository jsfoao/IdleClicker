using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public float cost;
    public float prodTime;
    public float prodAmount;

    public Item(string _name, float _cost, float _prodTime, float _prodAmount)
    {
        this.itemName = _name;
        this.cost = _cost;
        this.prodTime = _prodTime;
        this.prodAmount = _prodAmount;
    }
}
