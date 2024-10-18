using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletDespawn = 7f;
    void Start()
    {
        Invoke("OnBecameInvisible", bulletDespawn);   
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);       
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
