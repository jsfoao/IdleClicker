using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public PlayerManager playerManager;
    public Text goldText;
    public Text pressesText;
    public Button buyButton;
    public Button sellButton;

    private void Update()
    {
        goldText.text = "Gold: " + playerManager.gold;
        pressesText.text = "Presses: " + playerManager.totalPresses;

        //button colors
        if(playerManager.gold < playerManager.pressBuyPrice)
        {
            ChangeButtonColor(buyButton, Color.red);
        }
        else
        {
            ChangeButtonColor(buyButton, Color.green);
        }
    }

    private void ChangeButtonColor(Button _button, Color _newcolor)
    {
        ColorBlock colors = _button.colors;
        colors.normalColor = _newcolor;
        _button.colors = colors;
    }
}
