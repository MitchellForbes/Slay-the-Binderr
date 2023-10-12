using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurns : MonoBehaviour
{
    Enemy enemyTurn;
    CardSpawner playerTurn;
    PlayerEnergy playerEnergy;

    // Start is called before the first frame update

    public int debuffCountDown;
    void Start()
    {
        playerTurn = GameObject.FindGameObjectWithTag("CardSpawn").GetComponent<CardSpawner>();
        playerEnergy = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
        debuffCountDown = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void TurnEnd()
    {
        enemyTurn = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        //playerTurn = GameObject.FindGameObjectWithTag("CardSpawn").GetComponent<CardSpawner>();


        enemyTurn.DamagePlayer();
        playerTurn.DiscardHand();
        playerTurn.DrawCards();
        playerEnergy.ResetEnergy();

        if (enemyTurn.debuff == true)
        {
            debuffCountDown -= 1;
        }

        if (debuffCountDown == 0)
        {
            enemyTurn.debuff = false;
            debuffCountDown = 3;
        }
    }
}
