using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSlider : MonoBehaviour {
    public Image fuel;
    public bool fuel_active;
    public float fuel_rate;

    public GameOver GG;

    private float wait_timer;
    // Use this for initialization
    void Start () {
        fuel_rate = .003f;
	}
	
	// Update is called once per frame
	void Update () {
        wait_timer += Time.deltaTime;
        if (fuel_active)
        {
            if (wait_timer > .1f)       //At current rate lose 5% every second
            {
                if (fuel.fillAmount != 0)
                {
                    fuel.fillAmount -= fuel_rate;
                    wait_timer = 0;
                }
            }
            if(fuel.fillAmount == 0)
            {
                GG.Game_Over();
            }
        }
        

	}
}
