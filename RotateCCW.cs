using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCCW : MonoBehaviour {
    public MoveSat obj;
    private WaitForSeconds timer = new WaitForSeconds(.55f);
    public GameObject Cappi;
    public bool rotate_active;

    // Use this for initialization
    void Start () {
        rotate_active = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (rotate_active)
        {
            StartCoroutine(CapTurn());
        }
    }

    private IEnumerator CapTurn()
    {
        yield return timer;
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
}
