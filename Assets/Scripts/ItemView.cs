using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    public Player player;
    public Item item;

    private void Update()
    {
        Item.TotalGoldItemPerTime(item, player);
    }

    public void BuyItemButton()
    {
        Item.BuyItem(item, player);
    }

    public void UpgradeItemButton()
    {
        Item.UpgradeItem(item, player);
    }

    // changes object name in editor
    private void OnValidate()
    {
        gameObject.name = item.name;
    }
}
