using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDirection : MonoBehaviour {
    public GameObject sat;
    public MoveSat cappi;
    public Collider2D collide_obj;

    public bool rotate_active;

    private Vector3 ray;
    private Vector2 _2D;
    private int dir;
    // Use this for initialization
    void Start () {
        rotate_active = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && rotate_active)
        {
            Touch touch = Input.GetTouch(0);
            ray = Camera.main.ScreenToWorldPoint(touch.position);
            _2D = new Vector2(ray.x, ray.y);
            if (touch.phase == TouchPhase.Ended)
            {
                if (collide_obj == Physics2D.OverlapPoint(_2D))     //check if the beginning touch point is within the currently placed token
                {
                    print("startdirection");
                    dir = cappi.dir;
                    dir--;
                    if(dir < 0)
                    {
                        cappi.dir = 3;
                        cappi.direction = cappi.down;
                    }
                    if (dir == 0)
                    {
                        cappi.dir = 0;
                        cappi.direction = cappi.right;
                    }
                    if(dir == 1)
                    {
                        cappi.dir = 1;
                        cappi.direction = cappi.up;
                    }
                    if(dir == 2)
                    {
                        cappi.dir = 1;
                        cappi.direction = cappi.up;
                    }
                }
            }
        }
    }
}
