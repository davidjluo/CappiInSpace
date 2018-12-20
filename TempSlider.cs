using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TempSlider : MonoBehaviour {
    public Slider temperature;
    public bool temp_dec;
    public bool temp_inc;
    public float temp_rate;

    public GameOver GG;
    private float wait_timer;

    // Use this for initialization
    void Start () {
        temp_dec = false;
        temp_inc = false;
        temp_rate = .5f;
	}
	
	// Update is called once per frame
	void Update () {
        if (temp_inc || temp_dec)
        {
            wait_timer += Time.deltaTime;
            if (wait_timer > .1f)       //At current rate lose 5% every second
            {
                if (temperature.value != 0 && temp_dec)
                {
                    temperature.value -= temp_rate;
                    wait_timer = 0;
                }
                if (temperature.value != 1 && temp_inc)
                {
                    temperature.value += temp_rate;
                    wait_timer = 0;
                }
            }
            if(temperature.value == 0 || temperature.value == 100)
            {
                GG.Game_Over();
            }
        }       
    }
}
