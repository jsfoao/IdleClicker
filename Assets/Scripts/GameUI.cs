using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Player player;
    public Text goldText;
    public Text healthText;
    public Text attackDmgText;
    public GameObject itemFloatTextPrefab;

    private void Update()
    {
        goldText.text = "Gold: " + player.gold;
        healthText.text = "Health: " + player.currentHealth;
        attackDmgText.text = "Attack Dmg: " + player.attackDmg + " (" + player.attackRate + ")";
    }
}
