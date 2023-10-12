using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealCard : MonoBehaviour
{
    public CardSystem healCard;
    PlayerEnergy energyCost;

    public TextMeshPro nameText;
    public TextMeshPro energyText;
    public TextMeshPro descriptionText;
    private void Start()
    {
        energyCost = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerEnergy>();
        nameText.text = healCard.name;
        energyText.text = healCard.energCost.ToString();
        descriptionText.text = healCard.description;


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
        if (energyCost.currentEnergy >= healCard.energCost)
        {
            healCard.HealPlayer();
            energyCost.currentEnergy -= healCard.energCost;
            Debug.Log(energyCost.currentEnergy);
            Destroy(gameObject);
        }
    }
}
