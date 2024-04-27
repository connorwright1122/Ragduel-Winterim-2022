using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    public PlayerController playerController;

    private void Start()
    {
        playerController = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collide");
        
        if (collision.gameObject.tag == "Ground")
        {
            playerController.isGrounded = true;
        }

        //Debug.Log(playerController.isGrounded);
        //Debug.Log(playerController.isGrounded);
        
    }
}
