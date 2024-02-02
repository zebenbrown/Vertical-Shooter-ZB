using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().RepositionEnemy();
        }
    }
}
