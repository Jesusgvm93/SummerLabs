using System.Collections;
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
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
