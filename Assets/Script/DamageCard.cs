using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamageCard : MonoBehaviour
{
    public CardSystem attackCard;
    PlayerEnergy energyCost;

    public TextMeshPro nameText;
    public TextMeshPro energyText;
    public TextMeshPro descriptionText;
    private void Start()
    {
        energyCost = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
        nameText.text = attackCard.name;
        energyText.text = attackCard.energCost.ToString();
        descriptionText.text = attackCard.description;


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Test");
        }
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
