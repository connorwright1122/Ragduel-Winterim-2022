using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public float blinkIntensity;
    public float blinkDuration;
    public float blinkTimer;

    public bool isDead = false;

    public GameObject player;
    public GameObject sword;

    //public GameObject go;
    public SkinnedMeshRenderer smr;
    public UIHealthbarPlayer healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        //go = GetComponent<GameObject>();
        smr = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    private void Update()
    {
        /*
        blinkTimer -= Time.deltaTime;
        float lerp = Mathf.Clamp01(blinkTimer / blinkDuration);
        float intensity = (lerp * blinkIntensity) + 1.0f;
        smr.material.color = Color.white * intensity;
        */

        
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthbar.SetHealthBarPercentage(currentHealth / maxHealth);
        if (currentHealth <= 0.0f)
        {
            Die();
        }

        blinkTimer = blinkDuration;
    }

    private void Die()
    {
        //gameObject.SetActive(false);
        //player.SetActive(false);
        healthbar.gameObject.SetActive(false);
        sword.SetActive(false);
        isDead = true;
    }

    private void Respawn()
    {
        gameObject.SetActive(true);
    }
}
