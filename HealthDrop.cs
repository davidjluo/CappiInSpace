using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour {
    public GameObject cappi;
    public Collider2D col;

    public FuelSlider fuel;
    public TempSlider temp;

    public ObjPickedUp picked;
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
                if (col.OverlapPoint(_2D))
                {
                    if (picked.healthToken)
                    {
                        picked.placed_obj = true;
                        fuel.fuel_rate = .0015f;
                        
                    }
                    if (picked.tempToken)
                    {
                        picked.placed_obj = true;
                        temp.temp_rate = .25f;
                    }
                }
            }
        }
    }
}
