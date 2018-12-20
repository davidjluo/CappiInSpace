using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpButton : MonoBehaviour {
    public Collider2D collide_obj;
    public GameObject professor;
    public Text prof_text;

    private Vector3 ray;
    private Vector2 _2D;
    private WaitForSeconds timer = new WaitForSeconds(.1f);
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
                    print("work");
                    StartCoroutine(touchEnd());
                }

            }
        }
    }

    private IEnumerator touchEnd()
    {
        yield return timer;
        professor.SetActive(true);
        prof_text.text = "this is a hint";
    }
}
