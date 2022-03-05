using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject objectToEnable;
    public GameObject objectToDisable;
    public GameObject objectToEnable1;
    public GameObject objectToDisable1;
    public GameObject objectToEnable2;
    public GameObject objectToEnable3;


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

    private IEnumerator StartGame()
    {
        /*objectToEnable3.SetActive(true);
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        objectToEnable2.SetActive(true);*/
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }

}
