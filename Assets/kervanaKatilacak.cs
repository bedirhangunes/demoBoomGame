using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class kervanaKatilacak : MonoBehaviour
{
    public GameObject targett;
    NavMeshAgent agent;
    public GameObject[] targets;
    private int hedef;

    void Start()
    {
        hedef = 0;
        agent = GetComponent<NavMeshAgent>();   
    }

  
    void Update()
    {
        agent.SetDestination(targets[hedef].transform.position);

    }
     void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (hedef == 1)
            {
                hedef = 0;
                agent.SetDestination(targets[hedef].transform.position);
            }
            else
            {
                hedef++;
                agent.SetDestination(targets[hedef].transform.position);
            }

        }
      

    }
}
