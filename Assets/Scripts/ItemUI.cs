using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public PlayerManager playerManager;
    private Text buttonText;
    private Button button;
    public int index;
    private Item item;

    private void Start()
    {
        button = GetComponentInParent<Button>();
        buttonText = GetComponent<Text>();
        item = playerManager.items[index];
    }

    private void Update()
    {
        buttonText.text = item.name + "(" + item.total.ToString() + ")" + ": " + item.cost.ToString();

        if (item.cost < playerManager.gold)
        {
            ChangeButtonColor(button, Color.green);
        }
        else
        {
            ChangeButtonColor(button, Color.red);
        }
    }

    private void ChangeButtonColor(Button _button, Color _newcolor)
    {
        ColorBlock colors = _button.colors;
        colors.normalColor = _newcolor;
        _button.colors = colors;
    }
}
