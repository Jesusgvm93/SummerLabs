using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class Victory : MonoBehaviour
{
    //private int enemies;
    //public ARRaycastManager ARRaycastManager;
    //public GameObject objectToEnable;
    //public Camera arCamera;

    public Transform objectToFollow;
    public float speed = 0.07f;

    void Start()
    {
        //ARRaycastManager = FindObjectOfType<ARRaycastManager>();
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
        //StartCoroutine("Win");

        objectToFollow = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, objectToFollow.transform.position, (speed) * Time.deltaTime);
        transform.forward = objectToFollow.position - transform.position;

    }

    /*private IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        int enemies = GameObject.FindGameObjectsWithTag("Draugr").Length;
        Debug.Log(enemies);
        if (enemies == 0)
        {
            objectToEnable.SetActive(true);
            //SceneManager.LoadScene(1);
        }
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Wizard")
        {
            SceneManager.LoadScene(1);
        }
        else if (collision.gameObject.tag == "Draugr")
        {
            Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
        }

    }
}
