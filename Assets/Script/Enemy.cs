using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    private int damage;

    PlayerHealth playerHealth;

    public bool debuff = false;
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
        damage = Random.Range(4, 8);

        if (debuff == true)
        {
            damage /= 2;
            Debug.Log(damage);
        }

        playerHealth.health -= damage;
        Debug.Log("player Damaged");
    }

}
