using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class Victory : MonoBehaviour
{
    //private int enemies;
    public ARRaycastManager ARRaycastManager;
    public GameObject objectToEnable;
    //public Camera arCamera;

    void Start()
    {
        ARRaycastManager = FindObjectOfType<ARRaycastManager>();
    }
    void Update()
    {
        /*RaycastHit hit;
        Ray ray = arCamera.ScreenPointToRay(Input.touches[0].position);
        if (Physics.Raycast(ray, out hit))
        {
           if (hit.transform.tag == "Draugr")
           {
                StartCoroutine("Win");
           }
                    
        }*/
        StartCoroutine("Win");
            
    }

    private IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        int enemies = GameObject.FindGameObjectsWithTag("Draugr").Length;
        Debug.Log(enemies);
        if (enemies == 0)
        {
            objectToEnable.SetActive(true);
            //SceneManager.LoadScene(1);
        }
    }
}
