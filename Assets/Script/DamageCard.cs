using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCard : MonoBehaviour
{
    public CardSystem attackCard;
    PlayerEnergy energyCost;


    private void Start()
    {
        energyCost = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Card")
                {
                    attackCard.DamageEnemy();
                }
            }

        }
    }

    void AttackEnemy()
    {
        attackCard.DamageEnemy();
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
          if (energyCost.currentEnergy >= attackCard.energCost)
        {
            attackCard.DamageEnemy();
            energyCost.currentEnergy -= attackCard.energCost;
            Debug.Log(energyCost.currentEnergy);
            Destroy(gameObject);
        }
    }
}
