using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBorder : MonoBehaviour {
    private WaitForSeconds timer = new WaitForSeconds(.3f);
    public GameOver GG;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Border());
    }

    private IEnumerator Border()
    {
        yield return timer;
        GG.Game_Over();


    }
}
