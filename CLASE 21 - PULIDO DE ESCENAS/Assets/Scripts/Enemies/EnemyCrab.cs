using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCrab : Enemy
{

    protected override void Move()
    {
        base.Move();
        transform.Translate(Vector3.left * enemyStats.Speed * Time.deltaTime);
    }

}
