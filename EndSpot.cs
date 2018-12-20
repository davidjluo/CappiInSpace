using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSpot : MonoBehaviour {
    public bool exit;
    public GameObject cappi;
    public GameObject button;
    public Image f_img;
    public GameObject Home;
    public GameObject Hint;
    public GameObject Settings;

    public GameObject puzzle;
    public GameObject MenuBG;
    public GameObject LevelSelect;
    public GameObject GameBG;

    public int Level_num;
    public MoveSat sat;

    public ObjPickedUp status;
    public FuelSlider fuel;
    public Slider temp;
    public StartDirection cap;
    public StartGame init;
    public GameOver GG;
    public ScoreCounter Counter;
    public UpdateLevelSelect UpdateLevel;

    // Use this for initialization
    void Start () {
        exit = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(exit)
        {
            
            if(Counter.score == Counter.TotalData)
            {
                UpdateLevel.Update_Levels(3, Level_num);
                MenuBG.SetActive(true);
                GameBG.SetActive(false);
                LevelSelect.SetActive(true);
                puzzle.SetActive(false);
            }
            else if(init.trials == 0)
            {
                GG.Game_Over();
            }
            EndRecover();
        }
        exit = true;

    }

    public void EndRecover()
    {
        sat.speed = new Vector3(0, 0, 0);
        cappi.transform.localPosition = this.transform.localPosition;
        Vector3 temp_vect = cappi.transform.localPosition;
        temp_vect.z = 0;
        cappi.transform.localPosition = temp_vect;
        status.game_run = false;
        fuel.fuel_active = false;
        cap.rotate_active = true;
        button.SetActive(true);
        f_img.fillAmount = 1;
        temp.value = 50;
        Home.SetActive(true);
        Hint.SetActive(true);
        Settings.SetActive(true);
    }
}
