using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public PlayerManager playerManager;
    public Text goldText;

    private void Update()
    {
        goldText.text = "Gold: " + playerManager.gold;
    }
}
