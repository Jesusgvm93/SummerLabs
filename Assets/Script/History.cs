using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class History : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToDisable2;
    public GameObject objectToEnable;
    public GameObject objectToEnable2;
    void Update()
    {
        StartCoroutine("FindPlane");
    }

    private IEnumerator FindPlane()
    {

        yield return new WaitForSeconds(4f);
        objectToEnable.SetActive(true);
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(4f);
        objectToEnable2.SetActive(true);
        objectToDisable2.SetActive(false);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(3);
    }
}
