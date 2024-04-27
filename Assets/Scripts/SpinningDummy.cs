using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningDummy : MonoBehaviour
{
    [SerializeField] private float spinSpeed;

    private void FixedUpdate()
    {
        Vector3 rot = transform.localEulerAngles;
        rot.z += Time.deltaTime * spinSpeed;
        transform.localEulerAngles = rot;
    }
}
