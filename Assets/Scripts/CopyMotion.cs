using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint cj;

    Quaternion startRot;

    public bool mirror;

    private void Start()
    {
        cj = GetComponent<ConfigurableJoint>();
        startRot = transform.localRotation;
    }

    private void Update()
    {
        //cj.targetRotation = targetLimb.rotation;
        if (!mirror)//!inverse)
        {
            cj.targetRotation = targetLimb.localRotation * startRot;
        }

        else
        {
            cj.targetRotation = Quaternion.Inverse(targetLimb.localRotation) * startRot;
        }
    }
}
