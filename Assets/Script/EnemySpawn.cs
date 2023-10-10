using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    bool enemyalive;

    [SerializeField] GameObject Enemy;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Enemy"))
        {
            enemyalive = true;
        }
        else if(!GameObject.FindGameObjectWithTag("Enemy"))
        {
            enemyalive = false;
        }

        if (enemyalive == false)
        {
            Instantiate(Enemy, new Vector3(0, 3.5f, 0), Quaternion.identity);
            Debug.Log("spawned enemy");
        }
    }
}
