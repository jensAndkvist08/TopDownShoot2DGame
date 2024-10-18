using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] public float bulletReload = 0.5f; 
    public float playerBulletSpeed = 2f;
    [SerializeField] GameObject playerBullet;
    [SerializeField] GameObject playerGun;
    bool reloading = false;
    void Start()
    {
        
    }

    void OnFire()
    {



        if (reloading == false)
        {
            GameObject bullet = Instantiate(playerBullet, playerGun.transform.position, transform.rotation);
            Rigidbody2D rbb = bullet.GetComponent<Rigidbody2D>();
            rbb.AddForce(transform.up * playerBulletSpeed, ForceMode2D.Impulse);
            reloading = true;
            Invoke("reload", bulletReload);
        }
    }
    void reload()
    {
        reloading = false;
    }
   
    
    void Update()
    {
        
    }
}
