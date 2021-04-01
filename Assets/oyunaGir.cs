using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class oyunaGir : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void oyunaGiris()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void oyundanCikis()
    {
        Application.Quit();
    }
}
