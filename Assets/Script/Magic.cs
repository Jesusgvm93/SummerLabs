using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{

    public GameObject arCamera;
    //public GameObject explosion;

    RaycastHit hit;
    void Update()
    {   
        AttackMagic();
    }

    public void AttackMagic()
    {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.tag == "Draugr")
                {
                    Destroy(hit.transform.gameObject);
                    //Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                    //Destroy(explosion, 2f);
                }
            }
        }
    }
}
