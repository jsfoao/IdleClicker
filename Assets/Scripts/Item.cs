using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public float cost;
    public float prodTime;
    public float prodAmount;
    public float total;
    public float totalGold;
    public float timer;
    public bool reset;

    public Item(string _name, float _cost, float _prodTime, float _prodAmount)
    {
        this.name = _name;
        this.cost = _cost;
        this.prodTime = _prodTime;
        this.prodAmount = _prodAmount;
    }

    public static void BuyItem(Item _item, PlayerManager _playerManager)
    {
        if (_playerManager.gold >= _item.cost)
        {
            _item.total++;
            _playerManager.SubtractGold(_item.cost);
        }
        else
            Debug.Log("not enough");
    }

    public static void TotalGoldItemPerTime(Item _item, PlayerManager _playerManager)
    {
        _item.totalGold = 0;
        _item.totalGold = _item.prodAmount * _item.total;

        if (_item.total <= 0)
            return;

        _item.timer += Time.deltaTime;
        if (_item.timer >= _item.prodTime)
        {
            _item.reset = true;
            _item.timer = 0;
            _playerManager.AddGold(_item.totalGold);
        }
        else
            _item.reset = false;
    }
}

