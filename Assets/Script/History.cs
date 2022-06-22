using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class History : MonoBehaviour
{
    public int level;
    public int time;

    private void Awake()
    {
        //GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        StartCoroutine("FindPlane");
    }

    private IEnumerator FindPlane()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(level);
    }
}
