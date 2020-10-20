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
    [SerializeField] float pressBuyPrice;
    public float pressSellPrice;

    [Header("Timer")]
    public float delayAmount;
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

    public void BuyPress(float _buyPrice)
    {
        this.totalPresses++;
        SubtractGold(_buyPrice);
    }

    public void Sell(float _sellPrice)
    {
        this.totalPresses--;
        AddGold(_sellPrice);
    }

    private void GoldPerSecond()
    {
        goldPerSecond = pressIncrease * totalPresses;

        Timer += Time.deltaTime;
        if (Timer >= delayAmount)
        {
            Timer = 0f;
            gold += goldPerSecond;
        }
    }
}
