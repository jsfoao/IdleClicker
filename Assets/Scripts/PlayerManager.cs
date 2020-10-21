using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player")]
    public float gold;
    public float goldClick;

    public Item[] items;

    private void Update()
    {
        //gold per click
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }

        //gold per time
        TotalGoldItemPerTime(items[0]); //press
        TotalGoldItemPerTime(items[1]); //factory
    }

    public void AddGold(float _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(float _gold)
    {
        this.gold -= _gold;
    }

    public void BuyItem(Item _item)
    {
        if (this.gold >= _item.cost)
        {
            _item.total++;
            SubtractGold(_item.cost);
        }
        else
            Debug.Log("not enough");
    }

    public void TotalGoldItemPerTime(Item _item)
    {
        float totalGold = 0;
        totalGold = _item.prodAmount * _item.total;

        if (_item.total <= 0)
            return;

        _item.timer += Time.deltaTime;
        if (_item.timer >= _item.prodTime)
        {
            _item.timer = 0;
            AddGold(totalGold);
        }
    }

    public void BuyItemButton(int x)
    {
        BuyItem(items[x]);
    }
}