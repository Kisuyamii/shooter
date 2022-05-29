using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public int rocketSpeed;
    
    public float exploadRadius;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += transform.forward * rocketSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other) {
        if (!(other.gameObject.tag == "Player"))
        {
            RaycastHit[] allCast = Physics.SphereCastAll(transform.position, exploadRadius, transform.forward, 0.80f);
            foreach (RaycastHit hit in allCast)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
            Destroy(gameObject);
        }
        
    }
}
