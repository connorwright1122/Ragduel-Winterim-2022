using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipTransform : MonoBehaviour
{
    [SerializeField] Transform target;
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, target.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        //transform.LookAt(target);
        //transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, .01f);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation);

        //Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z); //flip? 
        Vector3 targetPosition = new Vector3(transform.position.x, target.position.y, transform.position.z); //flip? 
        //Quaternion targetPos = new Quaternion(targetPosition);
        //transform.LookAt(targetPosition);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetPosition, 1f);
    }
}
