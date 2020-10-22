using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public PlayerManager playerManager;
    private ItemView itemView;
    public Text ItemText;
    public Button buyButton;

    private void Start()
    {
        itemView = GetComponent<ItemView>();
    }

    private void Update()
    {
        ItemText.text = itemView.item.name + "(" + itemView.item.total.ToString() + ")" + ": " + itemView.item.cost.ToString();

        if (itemView.item.cost < playerManager.gold)
        {
            ChangeButtonColor(buyButton, Color.green);
        }
        else
        {
            ChangeButtonColor(buyButton, Color.red);
        }
    }

    private void ChangeButtonColor(Button _button, Color _newcolor)
    {
        ColorBlock colors = _button.colors;
        colors.normalColor = _newcolor;
        _button.colors = colors;
    }
}
