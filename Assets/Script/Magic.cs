using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magic : MonoBehaviour
{

    public GameObject arCamera;
    public Camera arCameraB;
    public GameObject explosion;
    public GameObject shield;
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
        if (button == true)
        {
            if (Input.touchCount > 2 )
            {
                Vector3 touchPos = arCameraB.WorldToScreenPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
                Instantiate(shield, touchPos, Quaternion.identity);
            }
            StartCoroutine("CountDownShield");
        }
        
        
    }

    private IEnumerator CountDownShield()
    {
        objectToDisable.SetActive(false);
        yield return new WaitForSeconds(3f);
        objectToDisable.SetActive(true);
        button = false;

    }
}
