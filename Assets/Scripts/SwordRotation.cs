using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRotation : MonoBehaviour
{
    public float dragSpeed = 1f;
    public float rotationSpeed = 1f;

    public float dragTime = 5f;
    public float offset = 1f;

    //Vector3 lastMousePosition;
    private Vector3 mOffset;

    private float mZCoord;
    //private float jo
    private float startTime;

    //private Vector3 currentPos;
    //private Quaternion currentRot;


    private Camera cam;

    //public GameObject player;

    public MouseLook mouseLook;


    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }




    private void Update()
    {
        /*
        //LMB
        if (Input.GetMouseButton(0))
        {
            //lastMousePosition = Input.mousePosition; 
            startTime = Time.time;
            Drag();
        }
        */

        if (Input.GetMouseButton(0))
        {
            //transform.parent.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));
            DragV2();
            //player.GetComponent<GameObject>().sensitivity = 0f;
            //mouseLook.sensitivity = 0f;
            //mouseLook.FlipSensitivity();
            Cursor.lockState = CursorLockMode.Confined;

            //NEW
            //currentPos = transform.parent.position;
        }
        
        else
        {
            //mouseLook.sensitivity = .5f;
            mouseLook.FlipSensitivity();
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        
        //RMB
        if (Input.GetMouseButton(1))
        {
            Rotation();
            //mouseLook.sensitivity = 0f;
            mouseLook.FlipSensitivity();
            Cursor.lockState = CursorLockMode.Confined;

            //NEW
            //currentRot = transform.parent.rotation;
        }
        /*
        else
        {
            mouseLook.sensitivity = .5f;
            Cursor.lockState = CursorLockMode.Locked;
        }
        */

        //NEW 
        //Quaternion newRot = transform.parent.rotation;
        //newRot.x = currentRot.x;
        //newRot.z = currentRot.z;
        //transform.parent.rotation = Quaternion.Lerp(transform.parent.rotation, newRot, dragSpeed * Time.deltaTime);

    }

    /*
    private void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.parent.position).z;
        //mOffset = gameObject.transform.parent.position - GetMouseWorldPos();

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }
    */

    /*
    private Vector3 GetMouseWorldPos()
    {
        //Screen pixel coords
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    */

    /*
    private void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.parent.Rotate(Vector3.down, xAxisRotation);
        transform.parent.Rotate(Vector3.right, yAxisRotation);
    }
    */



    private void DragV2()
    {
        //transform.parent.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));

        mouseLook.sensitivity = 0f;

        Vector3 startPos = transform.parent.position;
        Vector3 endPos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, offset)); //cam.transform.position.z)); // + 2f));
        //endPos z offset from camera position

        transform.parent.position = Vector3.Lerp(startPos, endPos, dragSpeed * Time.deltaTime);

    }

    //private void Drag()
    // {

    /*
    //Move - locked on z axis 
    Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z); //Camera.main.transform.position.z + transform.position.z);
    Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    transform.parent.position = mousePosition;
    */

    /*
    Vector3 delta = Input.mousePosition - lastMousePosition;
    Vector3 pos = transform.position;
    pos.y += delta.y * dragSpeed;
    transform.position = pos;
    lastMousePosition = Input.mousePosition;
    */


    /*
    //float currentTime = 0.0f;
    Vector3 startPos = transform.parent.position;
    //Vector3 startPos = transform.position;
    Vector3 endPos = GetMouseWorldPos() + mOffset;
    float journeyLength = Vector3.Distance(startPos, endPos);
    */

    /*
    while (currentTime < dragTime)
    {
        transform.parent.position = Vector3.Lerp(startPos, GetMouseWorldPos() + mOffset, currentTime / dragTime);
        currentTime += Time.deltaTime;
    }

    transform.parent.position = GetMouseWorldPos() + mOffset;

    */

    /*
    transform.position = GetMouseWorldPos() + mOffset;

    float distCovered = (Time.time - startTime) * dragSpeed;
    float fractionOfJourney = distCovered / journeyLength;
    */

    //transform.position = Vector3.Lerp(startPos, endPos, fractionOfJourney);
    //transform.parent.position = Vector3.Lerp(startPos, endPos, dragSpeed * Time.deltaTime);
    //transform.position = Vector3.Lerp(startPos, endPos, dragSpeed * Time.deltaTime);



    ////////////////////
    ///
    //transform.position = GetMouseWorldPos() + mOffset;


    //  }



    private void Rotation()
    {
        mouseLook.sensitivity = 0f;

        float xAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.parent.Rotate(Vector3.down, xAxisRotation);
        transform.parent.Rotate(Vector3.right, yAxisRotation);
    }

}
