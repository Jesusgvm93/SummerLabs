using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowUpWithTag : MonoBehaviour
{
    private GameObject wizard;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        wizard = GameObject.FindGameObjectWithTag("Wizard");

        if (wizard == null)
        {
            Debug.Log("Null");
        }
        else
        {
            Debug.Log("Wizard");
        }
    }
}
