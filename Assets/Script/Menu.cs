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

    public void StartScene()
    {
     SceneManager.LoadScene(1);
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

}
