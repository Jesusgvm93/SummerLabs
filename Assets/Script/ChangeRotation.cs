using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.position.x < Screen.width / 2)
            {
                Debug.Log("Left click");
                transform.rotation = Quaternion.Euler(0, -90, 0);

            }
            else if (touch.position.x > Screen.width / 2)
            {
                Debug.Log("Right click");
                transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }

    }
}
