using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteHole : MonoBehaviour {
    public MoveSat obj;
    private WaitForSeconds timer = new WaitForSeconds(.55f);
    public GameObject Cappi;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(CapTurn2());
    }

    private IEnumerator CapTurn2()
    {
        yield return timer;
        float rnd = Random.Range(0f, 2.0f);
        int turn = (int)rnd;
        if(turn == 0)       //Counter Clockwise Turn
        {
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
        }
        if(turn == 1)       //Clcok Wise Turn
        {
            int d = obj.dir;
            d -= 1;
            if (d < 0)
            {
                obj.dir = 3;
                obj.direction = obj.down;
            }
            if (d == 0)
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
            Vector3 center = transform.localPosition;
            Cappi.transform.localPosition = center;
        }


    }
}
