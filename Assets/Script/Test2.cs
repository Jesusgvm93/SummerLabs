using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Test2 : MonoBehaviour
{
    public ARRaycastManager ARRaycastManager;
    public GameObject draugr;
    private List<ARRaycastHit> aRRaycastHitsList = new List<ARRaycastHit>();
    RaycastHit hit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (ARRaycastManager.Raycast(Input.GetTouch(0).position, aRRaycastHitsList))
                {

                }
            }
        }
    }
}
