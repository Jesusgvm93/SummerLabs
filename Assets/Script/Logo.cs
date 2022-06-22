using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
