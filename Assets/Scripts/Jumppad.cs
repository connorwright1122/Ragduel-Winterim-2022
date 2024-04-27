using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public float jumppadSpeed;
    GameObject player;

    private void OnCollisionEnter(Collision collision)
    {
        player = collision.gameObject;
        Jump();
    }

    private void Jump()
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * jumppadSpeed, ForceMode.Impulse);
    }
}
