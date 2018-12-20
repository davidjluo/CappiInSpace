using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatSquare : MonoBehaviour {
    public TempSlider temp_bar;

    private bool control;
    // Use this for initialization
    void Start () {
        control = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (control)
        {
            temp_bar.temp_inc = true;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        control = true;
        temp_bar.temp_inc = true;

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        control = false;
        temp_bar.temp_inc = false;
    }


}
