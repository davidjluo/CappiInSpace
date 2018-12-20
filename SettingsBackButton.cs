using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsBackButton : MonoBehaviour {
    public GameObject prev;
    public GameObject settings;

    public Button set_button;
	// Use this for initialization
	void Start () {
        set_button.onClick.AddListener(return_set);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void return_set()
    {
        prev.SetActive(true);
        settings.SetActive(false);
    }
}
