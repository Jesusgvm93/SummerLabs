using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Magic1 : MonoBehaviour
{
    public ARRaycastManager ARRaycastManager;
    private List<ARRaycastHit> aRRaycastHitsList = new List<ARRaycastHit>();
    public GameObject explosion;
    public Camera arCamera;
    void Update()
    {
        if (Input.touchCount > 0)
        //if (Input.GetButtonDown("Fire1"))
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                Debug.Log("Left click");
                transform.rotation = Quaternion.Euler(0, -90, 0);

            }
            else if (touch.position.x > Screen.width / 2)
            {
                Debug.Log("Right click");
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                RaycastHit hit;
                //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Ray ray = arCamera.ScreenPointToRay(Input.touches[0].position);//Camera.main.ScreenPointToRay(Input.touches[0].position);
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Draugr")
                    {
                        Destroy(hit.transform.gameObject);
                        GameObject explosionS = Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                        //explosionS.transform.position = explosion.transform.position;
                        //Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                        Destroy(explosionS, 1f);
                    }
                }
            }
        }
    }
}
