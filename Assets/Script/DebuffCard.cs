using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebuffCard : MonoBehaviour
{
    public CardSystem debuffCard;
    PlayerEnergy energyCost;

    public TextMeshPro nameText;
    public TextMeshPro energyText;
    public TextMeshPro descriptionText;
    private void Start()
    {
        energyCost = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
        nameText.text = debuffCard.name;
        energyText.text = debuffCard.energCost.ToString();
        descriptionText.text = debuffCard.description;


    }

    //private void Update()
    //{
    //    if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

    //        RaycastHit hit;

    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            if (hit.transform.tag == "Card")
    //            {
    //                attackCard.DamageEnemy();
    //            }
    //        }

    //    }
    //}



    private void OnMouseDown()
    {
        if (energyCost.currentEnergy >= debuffCard.energCost)
        {
            debuffCard.DebuffEnemy();
            energyCost.currentEnergy -= debuffCard.energCost;
            Debug.Log(energyCost.currentEnergy);
            Destroy(gameObject);
        }
    }
}
