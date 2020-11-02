using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public Enemy enemy;

    // changes object name in editor
    private void OnValidate()
    {
        gameObject.name = enemy.name;
    }
}
