using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAIBasic : MonoBehaviour
{
    
    public Rigidbody hips;
    public float speed = 200f;
    public float stopDistance = 2f;
    public Transform flatEmpty;
    [SerializeField] private Transform target;

    public Animator animator;

    private void Start()
    {
        //hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        
        //flatEmpty.LookAt(target);
        //hips.AddForce(flatEmpty.transform.Vector3.forward * speed);
        //Vector3 flatEmptyVector = new Vector3(0, flatEmpty.transform.localEulerAngles.y, 0);
        //Debug.Log(flatEmpty.transform.localEulerAngles.x);
        //transform.localEulerAngles = flatEmptyVector;
        //hips.AddForce(flatEmptyVector * speed);

        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        //Debug.Log(distanceToTarget);

        if (distanceToTarget > stopDistance)
        {
            hips.AddForce(transform.forward * speed);
            animator.SetBool("isWalk", true);
        }

        else
        {
            animator.SetBool("isWalk", false);
        }

        //transform.LookAt(target);
        //hips.AddForce(transform.forward * speed);


        
    }
    

    /*
    private NavMeshAgent agent = null;
    [SerializeField] private Transform target;

    private void Start()
    {
        GetReferences();
    }

    private void FixedUpdate()
    {
        MoveToTarget();
    }

    private void GetReferences()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void MoveToTarget()
    {
        agent.SetDestination(target.position);
        agent.

        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        //if (distanceToTarget <= stopping)
    }
    */
    
}
