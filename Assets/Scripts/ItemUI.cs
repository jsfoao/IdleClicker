using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public PlayerManager playerManager;
    private Text buttonText;
    public int index;
    private void Start()
    {
        buttonText = GetComponent<Text>();
        buttonText.text = playerManager.items[index].itemName + ": " + playerManager.items[index].cost.ToString();
    }

    private void ChangeButtonColor(Button _button, Color _newcolor)
    {
        ColorBlock colors = _button.colors;
        colors.normalColor = _newcolor;
        _button.colors = colors;
    }
}
