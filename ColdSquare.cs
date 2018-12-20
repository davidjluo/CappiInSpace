using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdSquare : MonoBehaviour {
    public TempSlider temp_bar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        temp_bar.temp_dec = true;

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        temp_bar.temp_dec = false;
    }
}
