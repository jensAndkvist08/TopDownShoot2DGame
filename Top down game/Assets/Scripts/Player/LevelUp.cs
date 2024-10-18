using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    PlayerShoot playerShoot;
    PlayerDamage playerDamage;
    int playerExp = 0;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("exp"))
        {
            
            playerExp++;
            Destroy(collision.gameObject);
        }
    }

    public void PlayerLevelUp()
    {
        int timeLeveld = 0;
        if(playerExp >= (timeLeveld * 2))
        {
            playerDamage.playerHealth++;
            playerShoot.playerBulletSpeed++;
            timeLeveld++;
        }
    }

    void Update()
    {
        
    }
}
