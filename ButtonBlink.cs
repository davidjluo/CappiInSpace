using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

// this toggles a component (usually an Image or Renderer) on and off for an interval to simulate a blinking effect
public class ButtonBlink : MonoBehaviour
{
    public GameObject flashing_Label;

    public float interval;

    void Start()
    {
        InvokeRepeating("FlashLabel", 0, interval);
    }

    void FlashLabel()
    {
        if (flashing_Label.activeSelf)
            flashing_Label.SetActive(false);
        else
            flashing_Label.SetActive(true);
    }

}