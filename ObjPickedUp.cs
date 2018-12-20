using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPickedUp : MonoBehaviour {
    public bool clockToken;
    public bool ccwToken;
    public bool placed_obj;
    public bool trash;
    public bool healthToken;
    public bool tempToken;
    public bool health_token_used;
    public bool temp_token_used;

    public bool game_run;
	// Use this for initialization
	void Start () {
        clockToken = false;
        ccwToken = false;
        placed_obj = false;
        trash = false;
        game_run = false;
        healthToken = false;
        tempToken = false;
        health_token_used = false;
        temp_token_used = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Obj_Reset()
    {
        clockToken = false;
        ccwToken = false;
        placed_obj = false;
        trash = false;
        game_run = false;
        healthToken = false;
        tempToken = false;
        health_token_used = false;
        temp_token_used = false;
    }
}
