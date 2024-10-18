using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int playerHealth = 3;
    [SerializeField] public float iFrameTime = 2f;
    bool iFrame = false;
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Hazards") && iFrame == false)
        {            
            playerHealth--;
            if(playerHealth == 0)
            {
                Destroy(gameObject);
            }
            else
            {
                iFrame = true;
                Invoke("iFrameOver", iFrameTime);
            }
        }
        
    }
    void iFrameOver()
    {
        iFrame = false;
    }
}
