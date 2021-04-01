using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patlama : MonoBehaviour
{
 //   public GameObject explosion;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Fire")
        {
            Destroy(gameObject);
           // Destroy(col.gameObject);
           // Instantiate(explosion, transform.position, transform.rotation);
        }   
    }
}
