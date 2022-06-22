using UnityEngine;

public class ChangeRotation : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

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

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _animator.SetInteger("Attack", 1);
        }
        else
        {
            _animator.SetInteger("Attack", 0);
        }
    }
}
