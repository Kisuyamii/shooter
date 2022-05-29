using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public int amount;
    public string ammoType;

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
            collision.gameObject.transform.parent.gameObject.transform.GetChild(1).GetChild(0).GetComponent<WeaponManager>().ammo[ammoType] += amount;
            Destroy(gameObject);
        }
    }
}
