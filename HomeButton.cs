using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour {
    public Collider2D collide_obj;
    public GameObject puzzle;
    public GameObject recheck_panel;

    public RecheckBack recheck;

    private Vector3 ray;
    private Vector2 _2D;
    // Use this for initialization
    void Start()
    {

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
                    recheck_panel.SetActive(true);
                    puzzle.SetActive(false);
                    recheck.prev = puzzle;

                }

            }
        }
    }
}
