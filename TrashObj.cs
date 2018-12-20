using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashObj : MonoBehaviour {
    public Collider2D col;
    public GameObject trashcan;

    public ObjPickedUp pick_status;

    private Vector3 ray;
    private Vector2 _2D;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)       //check if touch is in progress
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)            //check if touch is ending
            {
                ray = Camera.main.ScreenToWorldPoint(touch.position);
                _2D = new Vector2(ray.x, ray.y);
                if (col.OverlapPoint(_2D))      //check if final touch position overlaps with trashcan
                {
                    if (pick_status.clockToken || pick_status.ccwToken)
                    {
                        pick_status.placed_obj = true;      //sets placed object as true
                        pick_status.trash = true;           //marks the placed object in trash
                    }
                }
                trashcan.SetActive(false);                  //deactivates trash can
            }
        }
    }
}
