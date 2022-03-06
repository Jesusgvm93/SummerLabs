using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class Test1 : MonoBehaviour
{
    public ARRaycastManager ARRaycastManager;
    private List<ARRaycastHit> aRRaycastHitsList = new List<ARRaycastHit>();
    
    public static bool button = false;
    public GameObject wall;
    public Button shieldB;
    public GameObject objectToDisable;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = shieldB.GetComponent<Button>();
        btn.onClick.AddListener(Shield);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && button == true)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (ARRaycastManager.Raycast(Input.GetTouch(0).position,aRRaycastHitsList))
                { 
                    Pose wallPosition = aRRaycastHitsList[0].pose;
                    wall.transform.position = wallPosition.position;
                    GameObject wallS = Instantiate(wall);
                    wallS.transform.position = wall.transform.position;
                    button = false;
                    Destroy(wallS, 3f);

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
