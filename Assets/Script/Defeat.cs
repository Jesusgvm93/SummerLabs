using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
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
