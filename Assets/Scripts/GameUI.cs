using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public PlayerManager playerManager;
    public Text goldText;
    public Text pressesText;
    public Text factoryText;

    private void Update()
    {
        goldText.text = "Gold: " + playerManager.gold;
    }
}
