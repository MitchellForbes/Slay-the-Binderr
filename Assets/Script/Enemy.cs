using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    public int damage = 3;

    PlayerHealth playerHealth;
    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        health = Random.Range(40, 50);
    }

    // Update is called once per frame
    void Update()
    {
       if (health <= 0)
        {
            Destroy(gameObject);
        }
    }




    public void DamagePlayer()
    {
        playerHealth.health -= damage;
        Debug.Log("player Damaged");
    }
}
