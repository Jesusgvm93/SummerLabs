using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowUp : MonoBehaviour
{
    public Transform objectToFollow;
    public float speed = 0.07f;
    void Update()
    {
        
        objectToFollow = GameObject.FindGameObjectWithTag("Wizard").GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, objectToFollow.transform.position, (speed ) * Time.deltaTime);
        transform.forward = objectToFollow.position - transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        SceneManager.LoadScene(0);
    }


}
