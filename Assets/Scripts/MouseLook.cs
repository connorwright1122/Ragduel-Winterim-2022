using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    /*
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    private float xRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
    */

    public Vector2 turn;
    public float sensitivity = .5f;

    private float sensitivityCopy;


    //1/6
    public ConfigurableJoint pelvisJoint;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //change when 
        Cursor.visible = true;
        sensitivityCopy = sensitivity;
    }

    private void Update() // 1/6 fixed instead of update
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        //1/6
        turn.y = Mathf.Clamp(turn.y, -60, 60);

        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);

        
    }

    private void FixedUpdate()
    {
        pelvisJoint.targetRotation = Quaternion.Euler(0, -turn.x, 0);
    }


    public void FlipSensitivity()
    {
        if (sensitivity == 0f)
        {
            sensitivity = sensitivityCopy;
        }

        else
        {
            sensitivity = 0f;
        }
    }
}
