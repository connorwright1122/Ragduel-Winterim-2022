using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        //Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        //transform.LookAt(targetPosition);


        //////
        ///
        /*
        Vector3 euler = target.transform.rotation.eulerAngles;
        Quaternion rot = Quaternion.Euler(euler.x, 0, euler.z);
        transform.localRotation = rot;
        */

        //transform.localEulerAngles = new Vector3(target.transform.localEulerAngles.x, target.transform.localEulerAngles.y, target.transform.localEulerAngles.z);
        //transform.localEulerAngles = new Vector3(target.transform.eulerAngles.x, target.transform.eulerAngles.y, target.transform.eulerAngles.z);
        //transform.localEulerAngles = new Vector3(target.transform.eulerAngles.x, 0, 0);
        transform.localEulerAngles = new Vector3(0, target.transform.eulerAngles.y, 0);
        //transform.localEulerAngles = new Vector3(0, 0, target.transform.eulerAngles.z);
        //transform.localEulerAngles = new Vector3(target.transform.eulerAngles.x, 0, target.transform.eulerAngles.z);
        //transform.localEulerAngles = new Vector3(0, target.transform.eulerAngles.y, target.transform.eulerAngles.z);
        //transform.localEulerAngles = new Vector3(target.transform.eulerAngles.x, target.transform.eulerAngles.y, target.transform.eulerAngles.z);
    }
}
