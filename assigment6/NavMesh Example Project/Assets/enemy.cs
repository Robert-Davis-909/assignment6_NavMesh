using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    public GameObject target = null;
    private NavMeshAgent navMeshA = null;

    private void Start()
    {
        navMeshA = this.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        navMeshA.SetDestination(target.transform.position);  
    }
}
