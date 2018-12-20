using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drop : MonoBehaviour {
    public GameObject CCW_token;
    public GameObject CW_token;
    public GameObject empty;
    public Collider2D col;
    public bool drop_active;

    public ObjPickedUp picked;

    private Vector3 ray;
    private Vector2 _2D;
	// Use this for initialization
	void Start () {
        drop_active = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (drop_active)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Ended)
                {
                    ray = Camera.main.ScreenToWorldPoint(touch.position);
                    _2D = new Vector2(ray.x, ray.y);
                    if (col.OverlapPoint(_2D))
                    {
                        if (picked.clockToken)
                        {
                            picked.placed_obj = true;
                            drop_active = false;
                            empty.GetComponent<SpriteRenderer>().sprite = CW_token.GetComponent<SpriteRenderer>().sprite;
                            empty.GetComponent<CWPlaced>().active = true;
                            empty.GetComponent<RotateCW90>().rotate_active = true;
                        }
                        if (picked.ccwToken)
                        {
                            picked.placed_obj = true;
                            drop_active = false;
                            empty.GetComponent<SpriteRenderer>().sprite = CCW_token.GetComponent<SpriteRenderer>().sprite;
                            empty.GetComponent<CCWPlaced>().active = true;
                            empty.GetComponent<RotateCCW>().rotate_active = true;
                        }
                    }
                }
            }
        }
		
	}
}
