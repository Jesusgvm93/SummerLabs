using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic1 : MonoBehaviour
{

    public GameObject arCamera;
    //public GameObject explosion;
    //public GameObject shield;

    RaycastHit hit;

    
    void Update()
    {

        AttackMagic();
        //Shield();
       
    }

    public void AttackMagic()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.tag == "Cat")
                {
                    Destroy(hit.transform.gameObject);
                    //Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                    //Destroy(explosion, 2f);
                }
            }
        }
    }

    /*public void Shield()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
                    Instantiate(shield, hit.transform.position, hit.transform.rotation);
                    Destroy(shield, 1f);
        }
    }

    private IEnumerator CountDownShield()
    {
        yield return new WaitForSeconds(2f);
    }*/
}
