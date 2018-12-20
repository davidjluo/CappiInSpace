using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public GameObject Cappi;
    public GameObject LaunchPad;
    public GameObject Puzzle;
    public GameObject GG_Panel;
    public GameObject PuzzleBG;
    public GameObject MenuBG;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Game_Over()
    {
        Cappi.transform.localPosition = LaunchPad.transform.localPosition;
        Puzzle.SetActive(false);
        GG_Panel.SetActive(true);
        PuzzleBG.SetActive(false);
        MenuBG.SetActive(true);
    }
}
