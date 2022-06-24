using UnityEngine;

public class CheckSound : MonoBehaviour
{
    private bool sound = false;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Mute()
    {
        if (sound == false)
        {
            AudioListener.volume = 0;
            sound = true;
        }
        else if (sound == true)
        {
            AudioListener.volume = 1;
            sound = false;
        }
    }
}
