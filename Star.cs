using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour {
    public MoveSat obj;
    private WaitForSeconds timer = new WaitForSeconds(.55f);
    public GameObject Cappi;
    public bool move_status;
    public GameObject button;
    public Button activate;

    public TempSlider temp_set;
    
    private float wait_timer;
    //public GameObject star_button;
    // Use this for initialization
    void Start () {
        move_status = false;
        wait_timer = 0;
        activate.onClick.AddListener(MoveOnClick);
	}
	
	// Update is called once per frame
	void Update () {
        wait_timer += Time.deltaTime;
        if (move_status)
        {
            temp_set.temp_inc = true;
        }
        if (move_status && (wait_timer > 1.5f))
        {
            //temp_set.temp_inc = true;
            int d = obj.dir;
            d += 1;
            if (d > 3)
            {
                obj.dir = 0;
                obj.direction = obj.right;
            }
            if (d == 1)
            {
                obj.dir = 1;
                obj.direction = obj.up;
            }
            if (d == 2)
            {
                obj.dir = 2;
                obj.direction = obj.left;
            }
            if (d == 3)
            {
                obj.dir = 3;
                obj.direction = obj.down;
            }
            Vector3 center = transform.localPosition;
            Cappi.transform.localPosition = center;
            wait_timer = 0;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(CapSpin());
    }

    private IEnumerator CapSpin()
    {
        yield return timer;
        obj.speed = new Vector3(0, 0, 0);
        button.SetActive(true);
        move_status = true;
        temp_set.temp_inc = true;
    }

    void MoveOnClick()
    {
        move_status = false;
        obj.speed = new Vector3(0, 1, 0);
        button.SetActive(false);
        temp_set.temp_inc = false;
    }
}
