using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] GameObject expOrb;
    [SerializeField] GameObject enemyPrefab;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            
            Destroy(gameObject);
            Instantiate(expOrb, enemyPrefab.transform.position, transform.rotation);
        }

    }
}
