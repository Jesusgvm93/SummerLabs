using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject explosion;
    public GameObject wall;
    private GameObject wallS;
    public GameObject objectToDisable;
    public static bool button = false;
    public Button shieldB;
    private Vector3 mousePos;
    private Vector3 prefab;
    public AudioSource wallSound;

    RaycastHit hit;

    void Start()
    {
        Button btn = shieldB.GetComponent<Button>();
        btn.onClick.AddListener(Shield);
    }

    void Update()
    {
        
        AttackMagic();
        
        /*if (Input.GetButtonDown("Fire1") && button == true)
        //if (Input.touchCount > 0  && Input.GetTouch(0).phase == TouchPhase.Began && button == true)
        {
            mousePos = Input.mousePosition;   // Input.GetTouch(0).position;
            mousePos.z = 1.5f;
            prefab = Camera.main.ScreenToWorldPoint(mousePos);
            wallS = Instantiate(wall, prefab, Quaternion.identity);
            //wallSound.Play();
            button = false;
            Destroy(wallS, 2f);
        }*/
    }

    public void AttackMagic()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.tag == "Draugr")
                {
                    Destroy(hit.transform.gameObject);
                    Instantiate(explosion, hit.transform.position, hit.transform.rotation);
                    Destroy(explosion, 2f);
                }
            }
        }
    }

    private void Shield()
    {
        Debug.Log("IsClicking");
        //button = true;    
        //StartCoroutine("CountDownShield");
    }

    /*private IEnumerator CountDownShield()
    {
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(3f);
        objectToDisable.SetActive(true);
        button = false;
    }*/
}
