using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class test : MonoBehaviour
{
    private ARRaycastManager aRRaycastManager;
    private Vector3 mousePos;
    private Vector3 prefab;
    public GameObject wall;
    private GameObject wallS;
    public static bool button = false;
    public float dWall;
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
        if (Input.touchCount > 0  && Input.GetTouch(0).phase == TouchPhase.Began && button == true) // Input.GetTouch(0).phase == TouchPhase.Began
        {
            var hits = new List<ARRaycastHit>();
            if (aRRaycastManager.Raycast(Input.GetTouch(0).position, hits))
            {            
            mousePos = Input.GetTouch(0).position;  //Input.mousePosition;  //  
            mousePos.z = dWall;
            prefab = Camera.main.ScreenToWorldPoint(mousePos);
            wallS = Instantiate(wall, prefab, Quaternion.Euler(0f,90f,0f) ); //Quaternion.identity
            //wallSound.Play();
            button = false;
            Destroy(wallS, 3f);
            }
           
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
