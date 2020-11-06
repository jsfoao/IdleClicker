using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    public GameObject enemy;
    private EnemyView enemyView;
    public Text hpText;
    public Text attackText;
    public Text enemyName;
    public Text lootText;

    private void Start()
    {
        enemyView = enemy.GetComponent<EnemyView>();
    }

    private void Update()
    {
        hpText.text = "HP: " + enemyView.enemy.currentHealth.ToString();
        attackText.text = "DMG: " + enemyView.enemy.attackDmg.ToString() + " (" + enemyView.enemy.attackRate.ToString() + ")";
        enemyName.text = enemyView.enemy.name;
        lootText.text = "Loot: " + enemyView.enemy.loot.ToString();
    }
}
