using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public int hp = 100;
    public NavMeshAgent agent;
    

  
    void Awake() {
       
    }

    void Update()
    {
        if (hp <= 0){
            Destroy(gameObject);
        }
    
    }

    public void TakeDamage(int damage) 
    {
        hp -= damage;
    }
}
