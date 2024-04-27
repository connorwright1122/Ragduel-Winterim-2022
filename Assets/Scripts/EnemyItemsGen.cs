using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyItemsGen : MonoBehaviour
{
    [SerializeField] private GameObject shinguardL;
    [SerializeField] private GameObject shinguardR;
    [SerializeField] private GameObject helmet;
    [SerializeField] private GameObject guantletL;
    [SerializeField] private GameObject guantletR;
    [SerializeField] private GameObject pauldronL;
    [SerializeField] private GameObject pauldronR;
    [SerializeField] private GameObject chestpiece;
    
    [SerializeField] private GameObject sword;
    [SerializeField] private GameObject spear;
    [SerializeField] private GameObject shield1;
    [SerializeField] private GameObject shield2;

    private bool sL;
    private bool sR;
    private bool h;
    private bool gL;
    private bool gR;
    private bool pL;
    private bool pR;
    private bool c;

    private int weapon;

    public Health health;
    private bool slicable = false;


    private void Start()
    {
        SetFalse();
        SetValues();
        SetArmor();
        SetWeapon();
    }


    private void Update()
    {
        MakeSlicable();
    }


    private void SetFalse()
    {
        shinguardL.SetActive(false);
        shinguardR.SetActive(false);
        helmet.SetActive(false);
        guantletL.SetActive(false);
        guantletR.SetActive(false);
        pauldronL.SetActive(false);
        pauldronR.SetActive(false);
        chestpiece.SetActive(false);

        sword.SetActive(false);
        spear.SetActive(false);
        shield1.SetActive(false);
        shield2.SetActive(false);
    }


    private void SetValues()
    {
        sL = (Random.value > 0.5f);
        sR = (Random.value > 0.5f);
        h = (Random.value > 0.5f);
        gL = (Random.value > 0.5f);
        gR = (Random.value > 0.5f);
        pL = (Random.value > 0.5f);
        pR = (Random.value > 0.5f);
        c = (Random.value > 0.5f);

        weapon = Random.Range(1, 5);
    }

    private void SetArmor()
    {
        if (sL)
        {
            shinguardL.SetActive(true);
        }
        

        if (sR)
        {
            shinguardR.SetActive(true);
        }
        
        
        if (h)
        {
            helmet.SetActive(true);
        }
        
        
        if (gL)
        {
            guantletL.SetActive(true);
        }
        

        if (gR)
        {
            guantletR.SetActive(true);
        }
        
        
        if (pL)
        {
            pauldronL.SetActive(true);
        }
        

        if (pR)
        {
            pauldronR.SetActive(true);
        }
        
        
        if (c)
        {
            chestpiece.SetActive(true);
        }
        

    }

    private void SetWeapon()
    {

        switch (weapon)
        {
            case 1:
                sword.SetActive(true);
                break;
            case 2:
                spear.SetActive(true);
                break;
            case 3:
                shield1.SetActive(true);
                break;
            case 4:
                shield2.SetActive(true);
                break;
        }
    }


    private void MakeSlicable()
    {
        if (health.currentHealth <= 15.0 && !slicable)
        {
            switch (weapon)
            {
                case 1:
                    sword.layer = LayerMask.NameToLayer("Slicable");
                    break;
                case 2:
                    spear.layer = LayerMask.NameToLayer("Slicable");
                    break;
                case 3:
                    shield1.layer = LayerMask.NameToLayer("Slicable");
                    break;
                case 4:
                    shield2.layer = LayerMask.NameToLayer("Slicable");
                    break;
            }

            slicable = true;
        }
    }

}
