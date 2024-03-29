using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardSystem : ScriptableObject
{
    public new string name;
    public string description;

    public int energCost;
    public int damage;
    public int heal;

    Enemy enemy;
    PlayerHealth player;
    PlayerTurns turns;

    public void DamageEnemy()
    {
        Debug.Log(damage);
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();

        enemy.health -= damage;
    }

    public void HealPlayer()
    {
        Debug.Log(heal);

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        player.health += heal;
    }


    public void DebuffEnemy()
    {
        Debug.Log("Enemy Debuffs");
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        turns = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerTurns>();

        enemy.debuff = true;
        turns.debuffCountDown = 3;
    }
}
