using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCWPlaced : MonoBehaviour {
    public GameObject obj;
    public Collider2D collide_obj;
    public Vector2 prev_loc;
    public bool objPicked;
    public bool active;
    public GameObject trashcan;

    public ObjPickedUp pick_obj;
    public CCWDragAndDrop orig_ccw;


    private Vector3 ray;
    private Vector2 _2D;
    private WaitForSeconds timer = new WaitForSeconds(.1f);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (active && (pick_obj.game_run == false))
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    trashcan.SetActive(true);
                    ray = Camera.main.ScreenToWorldPoint(touch.position);
                    _2D = new Vector2(ray.x, ray.y);
                    if (collide_obj == Physics2D.OverlapPoint(_2D))     //check if the beginning touch point is within the currently placed token
                    {
                        prev_loc = obj.transform.localPosition;     //set return position
                        objPicked = true;
                        pick_obj.ccwToken = true;
                        obj.GetComponent<RotateCCW>().rotate_active = false;
                    }

                }
                if ((touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) && objPicked)
                {
                    obj.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(touch.position).x, Camera.main.ScreenToWorldPoint(touch.position).y, 0.0f);     //follows finger
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    if (objPicked)      //checks if this is the current object being moved
                    {
                        StartCoroutine(touchEnd());
                    }
                }
            }
        }
    }

    private IEnumerator touchEnd()
    {
        yield return timer;
        objPicked = false;              //this object is no longer picked up
        pick_obj.ccwToken = false;    //clockwise rotation token no longer being moved         
        if (pick_obj.placed_obj)
        {
            obj.GetComponent<Drop>().drop_active = true;        //activates drop script so square can receive new token
            obj.transform.localPosition = prev_loc;
            pick_obj.placed_obj = false;        //tracks if the token was placed somewhere else
            active = false;                     //deactivates moving placed sprite on current empty squares
            obj.GetComponent<SpriteRenderer>().sprite = null;
            obj.GetComponent<RotateCCW>().rotate_active = false;
            if (pick_obj.trash)
            {
                pick_obj.trash = false;
                orig_ccw.ccw_token_remain++;        //if obj was placed in trash increment token counter
            }
        }
        else
        {
            obj.GetComponent<RotateCCW>().rotate_active = true;
            obj.transform.localPosition = prev_loc;
        }
    }
}
