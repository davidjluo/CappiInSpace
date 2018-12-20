using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {
    public Button start;
    public GameObject s;
    public MoveSat obj;
    public GameObject professor;
    public ObjPickedUp status;
    public FuelSlider fuel;
    public StartDirection cap;

    public GameObject Home;
    public GameObject Hint;
    public GameObject Settings;

    public int trials;
	// Use this for initialization
	void Start () {
        start.onClick.AddListener(StartGam);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void StartGam()
    {
        if(trials > 0)
        {
            obj.speed = new Vector3(0, 1, 0);
            s.SetActive(false);
            status.game_run = true;
            fuel.fuel_active = true;
            cap.rotate_active = false;
            trials--;
            Home.SetActive(false);
            Hint.SetActive(false);
            Settings.SetActive(false);
        }     
    }
}
