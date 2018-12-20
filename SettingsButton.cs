using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour {
    public Collider2D collide_obj;
    public GameObject puzzle;
    public GameObject puzzle_bg;
    public GameObject menu_panel;
    public GameObject menu_bg;
    public GameObject settings;

    public SettingsBackButton back;

    private Vector3 ray;
    private Vector2 _2D;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                ray = Camera.main.ScreenToWorldPoint(touch.position);
                _2D = new Vector2(ray.x, ray.y);
                if (collide_obj == Physics2D.OverlapPoint(_2D))     //check if the initial finger position is within clockwise rotation token
                {
                    puzzle.SetActive(false);
                    //puzzle_bg.SetActive(false);
                    menu_panel.SetActive(true);
                    //menu_bg.SetActive(true);
                    settings.SetActive(true);
                    back.prev = puzzle;
                }

            }
        }
    }
}
