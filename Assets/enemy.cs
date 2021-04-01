using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy : MonoBehaviour
{
    NavMeshAgent agentt;
    public GameObject enemys;

    void Start()
    {
        agentt = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        agentt.SetDestination(enemys.transform.position);
    }
}
