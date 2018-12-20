using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecheckBack : MonoBehaviour {
    public GameObject recheck;
    public GameObject prev;

    public Button back_button;
	// Use this for initialization
	void Start () {
        back_button.onClick.AddListener(back_return);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void back_return()
    {
        prev.SetActive(true);
        recheck.SetActive(false);
    }
}
