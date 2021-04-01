using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bitis : MonoBehaviour
{
    GameObject target;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag=="friend")
        {
            SceneManager.LoadScene("finishh");
        }
    }
}
