using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleAndRotate : MonoBehaviour
{

    private Slider scaleSlider;
    private Slider rotateSlider;

    public float scaleMinValue;
    public float scaleMaxValue;

    public float rotateMinValue;
    public float rotateMaxValue;

    void Start()
    {
        scaleSlider = GameObject.Find("Scale").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSlideUpdate);

        rotateSlider = GameObject.Find("Rotate").GetComponent<Slider>();
        rotateSlider.minValue = rotateMinValue;
        rotateSlider.maxValue = rotateMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSlideUpdate);
    }

    void ScaleSlideUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    void RotateSlideUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}
