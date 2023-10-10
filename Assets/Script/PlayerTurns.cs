using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurns : MonoBehaviour
{
    Enemy enemyTurn;
    CardSpawner playerTurn;
    PlayerEnergy playerEnergy;

    // Start is called before the first frame update
    void Start()
    {
        playerTurn = GameObject.FindGameObjectWithTag("CardSpawn").GetComponent<CardSpawner>();
        playerEnergy = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
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
    }
}
