using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBee : Enemy
{
    [SerializeField] private float delayJump = 5f;

    private Rigidbody rbEnemy;

    protected override void Start()
    {
        base.Start();
        rbEnemy = GetComponent<Rigidbody>();
        InvokeRepeating("JumpBee", 0f, delayJump);
        enemyStats.HP++;
    }

    private void JumpBee()
    {
        rbEnemy.AddForce(Vector3.up * enemyStats.Speed, ForceMode.Impulse);
    }
}
