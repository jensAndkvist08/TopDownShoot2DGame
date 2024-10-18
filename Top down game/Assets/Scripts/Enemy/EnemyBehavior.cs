using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    
    [SerializeField] float enemySpeed = 5f;
    Rigidbody2D erb;
    GameObject player;
    
    void Start()
    {
        erb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

   
    void Update()
    {
        if (player != null)
        {
            Vector2 direction = (player.transform.position - transform.position).normalized;
            erb.MovePosition(erb.position + direction * enemySpeed * Time.fixedDeltaTime);
        }
    }
}
