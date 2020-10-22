using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("Player")]
    public float gold;
    public float goldClick;
    private void Update()
    {
        //gold per click
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }
    }

    public void AddGold(float _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(float _gold)
    {
        this.gold -= _gold;
    }
}