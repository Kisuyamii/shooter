using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitPickup : MonoBehaviour
{
    public int healAmount;

    float spin;
    void Update() 
    {
        spin += Time.deltaTime * 50;
        transform.rotation = Quaternion.Euler(0, spin, 0);
        if (spin > 360) spin = 0;
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player") 
        {
            PlayerMovement player = collision.gameObject.GetComponent<PlayerMovement>();
            if(player.hp != player.GetMaxHp())
            {
                player.HealPlayer(healAmount);
                Destroy(gameObject);
            }    
        }
    }
}
