using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHitbox : MonoBehaviour
{
    public Health health;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Weapon")
        {
            health.TakeDamage(1);
            //Debug.Log("damage");
        }
    }
}
