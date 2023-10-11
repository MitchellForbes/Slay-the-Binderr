using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerEnergy : MonoBehaviour
{
    public int maxEnergy = 4;
    public int currentEnergy;

    public TextMeshProUGUI healthText;
    public TextMeshProUGUI energyText;
    public TextMeshProUGUI enemyHealthText;

    PlayerHealth healthGet;
    Enemy enemyHealth;
    void Start()
    {
        healthGet = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerText();
    }


    public void ResetEnergy()
    {
        currentEnergy = maxEnergy;
    }



    public void PlayerText()
    {
        enemyHealth = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        healthText.text = $"Health: {healthGet.health}";
        energyText.text = $"Energy: {currentEnergy}/{maxEnergy}";
        enemyHealthText.text = $"Enemy Health: {enemyHealth.health}";
    }
}
