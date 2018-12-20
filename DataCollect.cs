using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollect : MonoBehaviour {
    private WaitForSeconds timer = new WaitForSeconds(.55f);
    public GameObject data;
    public ScoreCounter score;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(DataC());
    }

    private IEnumerator DataC()
    {
        yield return timer;
        score.score++;
        data.SetActive(false);



    }
}
