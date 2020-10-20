using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player")]
    public int gold;
    public int goldClick;

    [Header("Press")]
    public int totalPresses;
    public int pressIncrease;
    public int pressBuyPrice;
    public int pressSellPrice;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }

        Debug.Log("Gold: " + gold);
        //Debug.Log("Gold presses: " + totalPresses);
    }

    public void AddGold(int _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(int _gold)
    {
        this.gold -= _gold;
    }

    public void BuyPress(int _buyPrice)
    {
        this.totalPresses++;
        SubtractGold(_buyPrice);
    }

    public void Sell(int _sellPrice)
    {
        this.totalPresses--;
        AddGold(_sellPrice);
    }
}
