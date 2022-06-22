using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {

    }

    public void Restart2()
    {
        SceneManager.LoadScene(0);
    }
}
