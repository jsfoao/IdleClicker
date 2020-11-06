using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Enemy
{
    public string name;
    public float attackRate;
    public float attackDmg;
    public float health;
    public float currentHealth;
    public float loot;
    public bool spawned;

    //timer
    public float timer;
    public bool reset;

    public Enemy(string _name, float _attackRate, float _attackDmg, float _health, float _loot, bool _spawned)
    {
        this.name = _name;
        this.attackRate = _attackRate;
        this.attackDmg = _attackDmg;
        this.health = _health;
        this.loot = _loot;
        this.spawned = _spawned;
        this.currentHealth = this.health;
    }

    public void TakeDamage(float _damage)
    {
        this.currentHealth -= _damage;
    }

    public void Respawn()
    {
        this.currentHealth = health;
    }

    public void DropLoot(Player _player)
    {
        _player.AddGold(this.loot);
    }

    public void DmgPerTime(Enemy _enemy, Player _player)
    {
        _enemy.timer += Time.deltaTime;
        if (_enemy.timer >= _enemy.attackRate)
        {
            _enemy.reset = true;
            _enemy.timer = 0;
            _player.TakeDamage(_enemy.attackDmg);
        }
        else
            _enemy.reset = false;
    }
}
