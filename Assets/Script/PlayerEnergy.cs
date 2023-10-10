using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour
{
    public int maxEnergy = 4;
    public int currentEnergy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetEnergy()
    {
        currentEnergy = maxEnergy;
    }
}
