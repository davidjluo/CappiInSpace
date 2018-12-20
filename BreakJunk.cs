using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreakJunk : MonoBehaviour {
    public Image fuel;
    public GameObject junk;

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
        amount = amount * .75f;
        fuel.fillAmount = amount;
        junk.SetActive(false);
      
    }
}
