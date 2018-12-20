using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsBackButton : MonoBehaviour {
    public GameObject prev;
    public GameObject Credits;

    public Button Credits_back;
	// Use this for initialization
	void Start () {
        Credits_back.onClick.AddListener(credits_return);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void credits_return()
    {
        Credits.SetActive(false);
        prev.SetActive(true);
    }
}
