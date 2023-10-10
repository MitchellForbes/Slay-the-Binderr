using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    List<GameObject> spawnPoints = new List<GameObject>();



    public GameObject card;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints.AddRange(GameObject.FindGameObjectsWithTag("CardSpawner"));

        foreach (GameObject Spawn in spawnPoints)
        {
            
            Instantiate(card, Spawn.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DrawCards()
    {
        foreach (GameObject Spawn in spawnPoints)
        {

            Instantiate(card, Spawn.transform.position, Quaternion.identity);
            Debug.Log("card Added");
        }
        Debug.Log("hand drawn");
    }

    public void DiscardHand()
    {
        GameObject[] hand = GameObject.FindGameObjectsWithTag("Card");
        foreach(GameObject cards in hand)
        {
            Destroy(cards);
            Debug.Log("card Destroy");
        }
        Debug.Log("Cards Destroyed");
    }

}
