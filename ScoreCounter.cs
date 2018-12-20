using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
    public Text scoreboard;
    public int score;
    public int TotalData;

    public Text clock_remain_counter;
    public CWDragAndDrop clock_script;

    public Text ccw_counter;
    public CCWDragAndDrop ccw_script;

    public Text health_token_counter;
    public HealthPowerupDrag health;

    public Text temp_token_counter;
    public TempPowerupDrag temp;

    public Text trial_remain_counter;
    public StartGame t;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreboard.text = "Data Collected: " + score.ToString() + "/" + TotalData.ToString();
        clock_remain_counter.text = clock_script.clock_token_remain.ToString();
        ccw_counter.text = ccw_script.ccw_token_remain.ToString();
        health_token_counter.text = health.health_token_remain.ToString();
        temp_token_counter.text = temp.temp_token_remain.ToString();
        trial_remain_counter.text = "Missions remaining: " + t.trials.ToString();
	}
}
