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

    RaycastHit hit;

    void Start()
    {
        Button btn = shieldB.GetComponent<Button>();
        btn.onClick.AddListener(Shield);
    }

    void Update()
    {
        
        AttackMagic();
        if (Input.touchCount > 0 && Input.GetTouch(1).phase == TouchPhase.Began)
        //if (Input.GetButtonDown("Fire1") && button == true)
        {
            Debug.Log("Fire1");
            //Vector3 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 cursorPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            wallS = Instantiate(wall, new Vector3(cursorPos.x, cursorPos.y, 0f), Quaternion.identity);
            //wallS = Instantiate(wall, cursorPos, Quaternion.identity);
            Destroy(wallS, 2f);
        }
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
