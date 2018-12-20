using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPowerupDrag : MonoBehaviour {
    public GameObject obj;
    public Collider2D collide_obj;
    public Vector2 prev_loc;
    public bool objPicked;
    public int temp_token_remain;
    public GameObject trashcan;

    public ObjPickedUp pick_obj;

    private Vector3 ray;
    private Vector2 _2D;
    private WaitForSeconds timer = new WaitForSeconds(.1f);

    // Use this for initialization
    void Start () {
        objPicked = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (temp_token_remain > 0 && (pick_obj.game_run == false) && pick_obj.temp_token_used == false)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    trashcan.SetActive(true);
                    ray = Camera.main.ScreenToWorldPoint(touch.position);
                    _2D = new Vector2(ray.x, ray.y);
                    if (collide_obj == Physics2D.OverlapPoint(_2D))     //check if the initial finger position is within clockwise rotation token
                    {
                        prev_loc = obj.transform.localPosition;     //save initial location
                        objPicked = true;
                        pick_obj.tempToken = true;
                    }

                }
                if ((touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) && objPicked)
                {
                    obj.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(touch.position).x, Camera.main.ScreenToWorldPoint(touch.position).y, 0.0f);
                }
                if (touch.phase == TouchPhase.Ended)
                {
                    if (objPicked)
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
        if (pick_obj.trash)     //if placed in trash only set picked to false
        {
            pick_obj.trash = false;
            pick_obj.placed_obj = false;
        }
        if (pick_obj.placed_obj)        //if placed in empty square decrement token counter
        {
            temp_token_remain--;
            pick_obj.placed_obj = false;
            pick_obj.temp_token_used = true;
        }
        objPicked = false;
        pick_obj.tempToken = false;
        obj.transform.localPosition = prev_loc;
    }
}
