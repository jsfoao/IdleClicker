using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

[System.Serializable]
public class Item
{
    //attributes item
    public string name;
    public float cost;
    public float prodTime;
    public float prodAmount;
    public float total;
    public float totalGold;

    //attributes upgrade
    public float upgradeCost;

    //timer
    public float timer;
    public bool reset;

    public Item(string _name, float _cost, float _prodTime, float _prodAmount)
    {
        this.name = _name;
        this.cost = _cost;
        this.prodTime = _prodTime;
        this.prodAmount = _prodAmount;
    }

    public static void BuyItem(Item _item, Player _player)
    {
        float buyIncrease = 1.1f;

        if (_player.gold >= _item.cost)
        {
            _item.total++;
            _player.SubtractGold(_item.cost);
            _item.cost = Mathf.Round(_item.cost * buyIncrease);
        }
        else
            Debug.Log("not enough");
    }

    public static void TotalGoldItemPerTime(Item _item, Player _player)
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
            _player.AddGold(_item.totalGold);
        }
        else
            _item.reset = false;
    }

    public static void UpgradeItem(Item _item, Player _player)
    {
        float upgradeIncrease = 1.05f;
        if (_player.gold >= _item.upgradeCost)
        {
            if (_item.total > 0)
            {
                _player.SubtractGold(_item.upgradeCost);
                _item.prodAmount = Mathf.Round(_item.prodAmount * upgradeIncrease * 100f) / 100f;
            }
            else
                Debug.Log("no items to upgrade");
        }
        else
            Debug.Log("not enough");
    }
}