using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class History : MonoBehaviour
{
    public int level;
    public int time;

    void Awake()
    {
        //GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(level);
    }
}
