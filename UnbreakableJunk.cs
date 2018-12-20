using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnbreakableJunk : MonoBehaviour {
    public Image fuel;
    public GameObject junk;
    public GameObject cappi;

    public MoveSat obj;
    private WaitForSeconds timer = new WaitForSeconds(.55f);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(CapSpin());
    }
    private IEnumerator CapSpin()
    {
        yield return timer;
        float amount = fuel.fillAmount;
        amount = amount * .5f;
        fuel.fillAmount = amount;
        int dir = obj.dir;

        float rnd = Random.Range(0f, 4.0f);
        int turn = (int)rnd;
        while(turn == dir)
        {
            rnd = Random.Range(0f, 4.0f);
            turn = (int)rnd;
        }
        if(turn == 0)
        {
            obj.dir = 0;
            obj.direction = obj.right;
        }
        if (turn == 1)
        {
            obj.dir = 1;
            obj.direction = obj.up;
        }
        if (turn == 2)
        {
            obj.dir = 2;
            obj.direction = obj.left;
        }
        if (turn == 3)
        {
            obj.dir = 3;
            obj.direction = obj.down;
        }
        Vector3 center = transform.localPosition;
        cappi.transform.localPosition = center;



    }
}
