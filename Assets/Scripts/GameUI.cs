using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Player player;
    public Text goldText;
    public GameObject itemFloatTextPrefab;

    private void Update()
    {
        goldText.text = "Gold: " + player.gold;
    }
}
