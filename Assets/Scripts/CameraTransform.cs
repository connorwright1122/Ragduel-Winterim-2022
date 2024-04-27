using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransform : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float yOffset;
    [SerializeField] float zOffset;
    [SerializeField] float dragSpeed;
    void Update()
    {
        //transform.position = new Vector3(target.position.x, target.position.y, target.position.z + offset);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z); //prev all target

        //Vector3 endPos = new Vector3(target.position.x, target.position.y + yOffset, target.position.z + zOffset);
        Vector3 endPos = new Vector3(target.position.x, target.position.y + yOffset, target.position.z + zOffset);

        /*
        float dist = Vector3.Distance(transform.position, endPos);

        Debug.Log(dist);

        if (dist < 10f)
        {
            transform.position = Vector3.Lerp(transform.position, endPos, dragSpeed * Time.deltaTime);

        }
        */

        //transform.position = Vector3.Lerp(transform.position, endPos, dragSpeed * Time.deltaTime);
        transform.position = endPos;
    }
}
