using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player")]
    public float gold;
    public float goldClick;
    public float attackRate = 0.6f;
    public float attackDmg = 5f;
    public float health = 100f;

    public GameObject enemyObject;
    private EnemyView enemyView;

    // timer
    public float timer;
    public bool reset;

    private void Start()
    {
        enemyView = enemyObject.GetComponent<EnemyView>();
    }

    private void Update()
    {
        //damage on enemy
        DmgPerTime(this, enemyView);

        //damage on player
        enemyView.enemy.DmgPerTime(enemyView.enemy, this);

        if (enemyView.enemy.currentHealth <= 0)
        {
            enemyView.enemy.Respawn();
            enemyView.enemy.DropLoot(this);
        }

        //gold per click
        if (Input.GetMouseButtonDown(0))
        {
            AddGold(goldClick);
        }
    }

    public void AddGold(float _gold)
    {
        this.gold += _gold;
    }

    public void SubtractGold(float _gold)
    {
        this.gold -= _gold;
    }

    public void TakeDamage(float _damage)
    {
        this.health -= _damage;
    }

    public void DmgPerTime(Player _player, EnemyView _enemyView)
    {
        _player.timer += Time.deltaTime;
        if (_player.timer >= _player.attackRate)
        {
            _player.reset = true;
            _player.timer = 0;
            _enemyView.enemy.TakeDamage(_player.attackDmg);
        }
        else
            _player.reset = false;
    }
}