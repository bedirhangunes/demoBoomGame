using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerContr : MonoBehaviour
{
    float horizontal, vertical,kafaroot=0;
    bool animayonControl = false;
    Vector3 vect;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        hareketler();
        if (Input.GetMouseButton(0))
        {
            animayonControl = true;
        }
        else
        {
            animayonControl = false;
        }
        animasyons();

    }
    void hareketler()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vect.Set(horizontal, 0, vertical);
        transform.Translate(vect * Time.deltaTime * 40);

        transform.Rotate(0, Input.GetAxis("Mouse X") * 10, 0);
        kafaroot += Input.GetAxis("Mouse Y") * Time.deltaTime * 150 * -1;
    }
    void animasyons()
    {
        if (animayonControl)
        {
            anim.SetBool("çekiç", true);
        }
        else
        {
            if (horizontal != 0 || vertical != 0)
            {
                anim.SetBool("walked", true);
            }
            else if (horizontal == 0 && vertical == 0)
            {
                anim.SetBool("walked", false);
            }
            anim.SetBool("çekiç", false);

        }
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "restart")
        {
          SceneManager.LoadScene("Level 1");
        }        
    }

}
