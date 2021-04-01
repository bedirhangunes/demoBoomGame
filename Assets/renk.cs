using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class renk : MonoBehaviour
{
    public float colourChangeDelay = 0.5f;
    float currentDelay = 0f;
    bool colourChangeCollision = false;
    public GameObject dost;
    NavMeshAgent age;
    public GameObject play;
    public float kapsamaAlani = 5f;
    float menzil;

    void Start()
    {
        age = GetComponent<NavMeshAgent>();
    }
    void OnCollisionEnter(Collision other)
    {
      
        colourChangeCollision = true;
        currentDelay = Time.time + colourChangeDelay;
    }
    void checkColourChange()
    {
        menzil = Vector3.Distance(play.transform.position, transform.position);
        if (colourChangeCollision)
        {
         //dost.GetComponentInChildren<Renderer>().material.color = Color.green;
            if (menzil<=kapsamaAlani)
            {
                dost.GetComponentInChildren<Renderer>().material.color = Color.green;
                colourChangeCollision = false;
                age.SetDestination(play.transform.position);
            }
        }
    }

    void Update()
    {
        checkColourChange();
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, kapsamaAlani);
    }
}
