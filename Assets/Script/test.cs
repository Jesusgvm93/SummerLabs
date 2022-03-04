using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 prefab;
    public GameObject wall;
    private GameObject wallS;
    public static bool button = false;
    public GameObject objectToDisable;
    public Button shieldB;
    void Start()
    {
        Button btn = shieldB.GetComponent<Button>();
        btn.onClick.AddListener(Shield);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1") && button == true)
        if (Input.touchCount > 0  && Input.GetTouch(0).phase == TouchPhase.Began && button == true)
        {
            mousePos = Input.GetTouch(0).position; //Input.mousePosition;   // 
            mousePos.z = 1.5f;
            prefab = Camera.main.ScreenToWorldPoint(mousePos);
            wallS = Instantiate(wall, prefab, Quaternion.identity);
            //wallSound.Play();
            button = false;
            Destroy(wallS, 2f);
        }
    }

    private void Shield()
    {
        Debug.Log("IsClicking");
        button = true;
        StartCoroutine("CountDownShield");
    }

    private IEnumerator CountDownShield()
    {
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(3f);
        objectToDisable.SetActive(true);
        button = false;
    }
}
