using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 30;
    public int maxHealth = 30;

    public GameObject gameoverUI;
    void Start()
    {
        health = 30;
        maxHealth = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        if (health <= 0)
        {
            gameoverUI.SetActive(true);
            Scene scene = SceneManager.GetActiveScene();
            Invoke("ReloadScene", .5f);
        }
    }

    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }



}
