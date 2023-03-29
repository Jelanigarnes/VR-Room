using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class sliderDisplay : MonoBehaviour
{
    public Slider slider;
    public TMP_Text text;

    void Start()
    {
        // Get a reference to the slider component
        slider = GetComponent<Slider>();

        // Get a reference to the text component
        text = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        // Update the text component with the current slider value
        text.text = slider.value.ToString("1");
    }
}
