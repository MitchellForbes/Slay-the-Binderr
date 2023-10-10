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

    public void DamageEnemy()
    {
        Debug.Log(damage);
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();

        enemy.health -= damage;
    }
}
