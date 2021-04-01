using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bitisCizgisi : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "friend")
        {
            SceneManager.LoadScene("finishh");
        }
    }
}
