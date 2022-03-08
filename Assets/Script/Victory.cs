using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Win");
    }

    private IEnumerator Win()
    {

        yield return new WaitForSeconds(10f);
        if (GameObject.FindGameObjectsWithTag("Draugr").Length == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
