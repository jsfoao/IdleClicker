using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemView : MonoBehaviour
{
    public PlayerManager playerManager;
    public Item item;

    private void Update()
    {
        Item.TotalGoldItemPerTime(item, playerManager);
    }

    public void BuyItemButton()
    {
        Item.BuyItem(item, playerManager);
    }

    public void UpgradeItemButton()
    {
        Item.UpgradeItem(item, playerManager);
    }

    // changes object name in editor
    private void OnValidate()
    {
        gameObject.name = item.name;
    }
}
