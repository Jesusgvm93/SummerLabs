using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject objectToEnable;
    public GameObject objectToDisable;
    public GameObject objectToEnable1;
    public GameObject objectToDisable1;
    public GameObject objectToEnable2;
    public GameObject objectToDisable2;
    public AudioSource intro;

    public void StartScene()
    {
        StartCoroutine("StartGame");
    }

    public void Settings()
    {
        objectToDisable.SetActive(false);
        objectToEnable.SetActive(true);
    }

    public void MainMenu()
    {
        objectToDisable1.SetActive(false);
        objectToEnable1.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Credits()
    {
        SceneManager.LoadScene(9);
    }

    private IEnumerator StartGame()
    {
        objectToEnable2.SetActive(true);
        objectToDisable2.SetActive(false);
        intro.Play();
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(2);
    }

    public void Mute()
    {   
        AudioListener.volume = 0;
    }
}
