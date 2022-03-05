using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{
    void Update()
    {
        StartCoroutine("Mainmenu");
    }

    private IEnumerator Mainmenu()
    {

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
}
