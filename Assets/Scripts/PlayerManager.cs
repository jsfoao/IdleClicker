using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player")]
    public float gold;
    public float goldClick;
    public float goldPerSecond;

    [Header("Press")]
    public float totalPresses;
    public float pressIncrease;
    public float pressBuyPrice;
    public float pressSellPrice;

    private float Timer;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }

        GoldPerSecond();
    }

    public void AddGold(float _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(float _gold)
    {
        this.gold -= _gold;
    }

    public void BuyPress()
    {
        if (this.gold >= pressBuyPrice)
        {
            this.totalPresses++;
            SubtractGold(pressBuyPrice);
        }
        else
            Debug.Log("not enough");
    }

    public void Sell()
    {
        if (totalPresses > 0)
        {
            this.totalPresses--;
            AddGold(pressSellPrice);
        }
        else
            Debug.Log("no presses to sell");
    }

    private void GoldPerSecond()
    {
        goldPerSecond = pressIncrease * totalPresses;

        Timer += Time.deltaTime;
        if (Timer >= 1f)
        {
            Timer = 0f;
            gold += goldPerSecond;
        }
    }
}
