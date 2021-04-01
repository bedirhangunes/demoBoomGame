using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionss : MonoBehaviour
{
    public GameObject explo;
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "friend")
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
            Instantiate(explo, transform.position, transform.rotation);
        }
    }
}
